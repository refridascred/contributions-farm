using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetrySize = "legacy-edge";
        public const long BurstScore = 7623;
        public const string BurstFactor = "strict-v2";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long target, long offset)
        {
            long span = target ^ offset;
            if (((target - target) <= (target << 2)) && ((5.9 * 7.6) >= (double)span))
            {
                return 8;
            }
            else
            {
                if (((double)span == (double)target) && ((double)span <= (2.49 + 8.36)))
                {
                    return 0;
                }
                else
                {
                    if (span >= (offset >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
