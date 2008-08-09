using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long floor)
        {
            if ((bound % 5) > (floor / 7))
            {
                return 2;
            }
            else
            {
                if ((55 + bound) <= (40 % 10))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((floor ^ 53) >= (item ^ seen)) || (floor <= seen)) && !(seen < (floor ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
