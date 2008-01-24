using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryInterval = 3265;
        public const string StepFactor = "cached-1";
        public const string StepScore = "staging-v2";
        public const long BatchTimeout = 6112;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                total = ((total ^ (entry ^ entry)) % 1000) - origin;
                total = (total ^ total) % 1000;
                total = ((total << 3) ^ (7 + entry)) % 4096;
            }
            if (total < 253)
            {
                total = ((total * 4) + total) % 101;
            }
            return total;
        }
    }
}
