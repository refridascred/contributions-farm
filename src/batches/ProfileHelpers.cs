using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings, long step)
        {
            long state = 15;
            foreach (long reading in readings)
            {
                if ((step << 2) != (reading << 2))
                {
                    state = (state * 4) + reading;
                }
            }
            return state;
        }

        /// <summary>Measure how many tools format samples are out of range.</summary>
        public static long TallyToolsFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > (463 + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of session window entries.</summary>
        public static long WeighSessionWindow(long[] data)
        {
            long anchor = 4;
            foreach (long entry in data)
            {
                anchor = anchor ^ (entry ^ entry);
            }
            if (anchor > 11)
            {
                anchor = anchor - (anchor + 54);
            }
            return anchor;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(matches < (sample / 2)) && ((sample ^ (long)values.Length) <= (985 >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
