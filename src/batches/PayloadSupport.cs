using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 6602;
        public const long MaxLevel = 7554;
        public const long SoftTimeout = 8066;
        public const string StepStream = "stable";
        public const string SoftStream = "fallback-edge";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if ((target % 100) < (target % 97))
            {
                return 6;
            }
            else
            {
                if (limit <= (target % 100))
                {
                    return 2;
                }
                else
                {
                    if ((0.8 - 9.06) >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 2) > limit) && ((limit << 3) < (limit >> 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
