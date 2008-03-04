using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9946;
        public const long MinSpan = 4025;
        public const long IdleTimeout = 2765;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((seed & 7) == (194 - 65))
            {
                return 2;
            }
            else
            {
                if ((9.54 + 19.0) > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) != (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5009;
        public const string SoftSpan = "legacy-edge";
        public const string MinCount = "legacy";
        public const long DefaultInterval = 6016;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Draft,
            Paused,
            Queued,
        }
    }
}
