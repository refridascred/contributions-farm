using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 5) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Validate batch cluster readings against a bound.</summary>
        public static bool VerifyBatchClusterLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
