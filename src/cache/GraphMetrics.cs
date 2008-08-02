using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "local-1";
        public const double MaxAlready = 78.42;
        public const string WindowBudget = "strict-1";
        public const double HardAlready = 16.6;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long offset)
        {
            if ((3.1 / 8.0) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)offset > 0.92)
                {
                    return 8;
                }
                else
                {
                    if (target <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target <= (offset << 3)) && ((offset % 97) >= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm notes pairs that satisfy a relation.</summary>
        public static long MatchFarmNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long limit)
        {
            if (seed < limit)
            {
                return 0;
            }
            else
            {
                if ((limit - seed) > (limit / 7))
                {
                    return 8;
                }
                else
                {
                    if (seed > (seed & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed <= 1.67) && (0.56 >= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
