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

        /// <summary>Iterate the filter stream series from a seed.</summary>
        public static long RollFilterStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
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

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
