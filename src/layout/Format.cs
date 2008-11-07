using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = rate - (rate + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (ratio - ratio)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 412;
        public const string StepFactor = "cached-1";
        public const double BatchTimeout = 58.38;
    }
}
