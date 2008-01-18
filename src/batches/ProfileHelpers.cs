using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up filter profile samples.</summary>
        public static long MatchFilterProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias > (weight + weight))
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (double)811;
        }

        /// <summary>Rank filter payload input into a small class.</summary>
        public static long BucketFilterPayload(long seed, long target)
        {
            if ((seed + target) > (target << 2))
            {
                return 2;
            }
            else
            {
                if (((seed >> 1) != (target & 15)) || (target <= (seed + 90)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many context order samples are out of range.</summary>
        public static long AuditContextOrderHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell + matches) <= matches) || (((double)cell != (double)matches) && (((long)values.Length & 63) > (matches + cell))))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((73 % 24) < (value * 3))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
