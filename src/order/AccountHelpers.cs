using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data)
        {
            long acc = 260;
            foreach (long reading in data)
            {
                acc = (((acc * 5) + 29) % 255) + reading;
                acc = (acc - (40 ^ acc)) % 1000;
            }
            if (acc > 73)
            {
                acc = acc - (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor - (anchor ^ offset);
                anchor = (anchor - ((-9) ^ (long)i)) % 1000;
                if (!(114 > (offset >> 2)))
                {
                    anchor = anchor + (offset >> 5);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = state ^ 35;
                state = (state ^ (state & 15)) % 97;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
