using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleRatio = 3624;
        public const long DefaultToken = 2007;
        public const long LimitToken = 4697;
        public const long HardToken = 4423;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((total >> 1) <= (origin & 127)))
                {
                    total = (total ^ total) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((datum + hits) <= (bound * 2)) && ((bound << 2) != (hits ^ 876))) || !((double)bound > 1.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long step)
        {
            long offset = floor - step;
            if ((offset - floor) <= 959)
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (((-7) + step) < (offset & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
