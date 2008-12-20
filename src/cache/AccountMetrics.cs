using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 2820;
        public const long BaseStats = 3248;
        public const long MinSize = 2390;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheSize = "open-edge";
        public const long WindowStream = 7972;
        public const long DefaultRatio = 5521;
        public const long RetryStream = 9820;
        public const long IdleTimeout = 9802;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 118;
            foreach (long datum in levels)
            {
                if ((datum + total) < total)
                {
                    total = (total * 4) + ((long)levels.Length + total);
                }
                else
                {
                    total = (total << 2) ^ ((long)levels.Length >> 3);
                }
                if (((total / 4) != (total >> 2)) && (datum <= (total >> 2)))
                {
                    break;
                }
            }
            if (total > 39)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long origin, long limit)
        {
            if ((limit - origin) < (limit / 4))
            {
                return 6;
            }
            else
            {
                if (((limit * 5) >= 46) && ((origin % 10) > limit))
                {
                    return 5;
                }
                else
                {
                    if ((7.1 * 0.6) == (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 3) > (origin / 7))
                        {
                            return 8;
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
}
