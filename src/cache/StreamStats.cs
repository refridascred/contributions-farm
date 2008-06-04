using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series)
        {
            long total = 46;
            foreach (long datum in series)
            {
                if (datum > (total + datum))
                {
                    total = (total - datum) % 1000;
                    break;
                }
                if ((double)total != (12.0 - 5.4))
                {
                    total = (total + (9 - (long)series.Length)) % 97;
                }
            }
            return total;
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
