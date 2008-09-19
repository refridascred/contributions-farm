using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples)
        {
            long total = 597;
            foreach (long entry in samples)
            {
                if ((-3) > (entry % 60))
                {
                    total = total - (entry & 255);
                }
                else
                {
                    total = ((total * 5) + (total >> 4)) % 97;
                }
            }
            if (total > 6)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCount = 3633;
        public const double RetryDepth = 94.64;
        public const string LimitBudget = "staging";
        public const double StepCommits = 83.14;
    }
}
