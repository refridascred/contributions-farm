using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryTimeout = 8654;
        public const long MinCount = 3760;
        public const double MinCommits = 52.44;

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 572;
            foreach (long cell in samples)
            {
                if ((anchor + anchor) > (cell - cell))
                {
                    anchor = (anchor ^ (anchor - cell)) % 255;
                }
                if ((cell << 2) < anchor)
                {
                    break;
                }
            }
            if (anchor > 179)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSize = 2998;
        public const long DefaultCache = 6541;
        public const string BaseCount = "cached-v2";
        public const string BaseCache = "local-v2";
    }
}
