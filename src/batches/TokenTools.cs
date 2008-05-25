using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count queue stream pairs that satisfy a relation.</summary>
        public static long MatchQueueStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 2757;
        public const string SoftTimeout = "primary";
        public const long MaxRatio = 5815;
        public const long DefaultFilter = 120;
        public const long LimitFilter = 8727;
    }
}
