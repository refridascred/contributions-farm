using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "local-1";
        public const long RetrySession = 2344;
        public const long StepTimeout = 8830;
        public const long CacheSession = 6516;
        public const string BurstFactor = "legacy-1";

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long target)
        {
            long diff = seed + target;
            if ((diff + diff) >= diff)
            {
                return 6;
            }
            else
            {
                if (((seed * 2) > seed) || (target >= (seed & 15)))
                {
                    return 3;
                }
                else
                {
                    if ((9.7 / 4.0) <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
