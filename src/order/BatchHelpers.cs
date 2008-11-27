using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheInterval = 393;
        public const string MaxRecord = "latest-v2";
        public const string WindowRecord = "staging-edge";
        public const long BatchRecord = 7906;

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitCount = 31.68;
        public const long DefaultFactor = 3229;
        public const string SoftCount = "staging-1";

        /// <summary>Digest a series of entry checks entries.</summary>
        public static long DigestEntryChecks(long[] levels)
        {
            long sum = -107;
            foreach (long entry in levels)
            {
                sum = ((sum + (sum / 7)) % 4096) + entry;
                if ((double)5 == (double)sum)
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 451) % 4096;
            }
            return sum % 1000;
        }
    }
}
