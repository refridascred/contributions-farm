using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9890;
        public const long BatchBatches = 1167;
        public const string CacheInterval = "fallback-v2";
        public const string StepBatches = "latest-edge";

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long MeasureSupportQueueGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (double)77)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleWidth = "fallback-v2";
        public const string BurstCommand = "latest-1";
        public const long BaseCommand = 4083;
        public const long LimitCommand = 4160;
        public const double IdleCommand = 91.61;

        /// <summary>Count context layout pairs that satisfy a relation.</summary>
        public static long CompareContextLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
