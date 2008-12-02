using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftScore = 51.88;
        public const double SoftReport = 50.08;
        public const string WindowScore = "latest-1";

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long target)
        {
            if (((target << 3) < (target >> 5)) && ((bound - target) <= bound))
            {
                return 7;
            }
            else
            {
                if ((target >= (target / 9)) && ((bound & 15) < (target >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound >= (double)target) || ((target % 2) < 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (17.0 / 8.0))
                {
                    anchor = ((anchor * 4) + ((long)i << 1)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
