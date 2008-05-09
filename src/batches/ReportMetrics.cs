using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8301;
        public const long MinStream = 1358;
        public const long DefaultRatio = 5913;
        public const long WindowStream = 3906;

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryWidth = 18.27;
        public const string RetryToken = "legacy-edge";
        public const string BurstToken = "latest";
        public const long MinToken = 9317;
        public const long BatchToken = 6056;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (9.0 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
