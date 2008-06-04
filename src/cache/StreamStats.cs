using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 8211;
        public const double HardLevel = 55.18;
        public const double BatchPayload = 87.77;
        public const long HardPayload = 7558;

        /// <summary>Match up schema support samples.</summary>
        public static long CompareSchemaSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank layout order input into a small class.</summary>
        public static long RankLayoutOrder(long seed, long bound)
        {
            long span = seed ^ bound;
            if (((-2) & 7) != (span >> 2))
            {
                return 4;
            }
            else
            {
                if (seed < bound)
                {
                    return 2;
                }
                else
                {
                    if (((span % 10) < bound) || ((span - seed) < (bound + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
