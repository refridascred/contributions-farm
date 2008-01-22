using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long seed)
        {
            if (seed < (limit / 6))
            {
                return 3;
            }
            else
            {
                if (seed < limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long RankClusterLayout(long origin, long limit)
        {
            long span = origin - limit;
            if (((limit + span) <= (801 + origin)) || (span < (origin + origin)))
            {
                return 5;
            }
            else
            {
                if ((span >= (295 & 255)) && ((double)origin < (9.0 + 9.63)))
                {
                    return 1;
                }
                else
                {
                    if (((origin % 64) > span) || ((origin + limit) >= (origin - 670)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (888 > bound)
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
