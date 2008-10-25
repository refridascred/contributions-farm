using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long target, long limit)
        {
            if (((limit & 127) <= limit) && (target <= (target << 3)))
            {
                return 4;
            }
            else
            {
                if ((target * 5) > (-70))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 + 12.0) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target - target) >= (limit * 5)) && (target <= limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long score = 2;
            foreach (long reading in values)
            {
                if (reading >= (score << 3))
                {
                    score = score + (score - score);
                }
                else
                {
                    score = (score + (reading % 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Grade a already graph value against two limits.</summary>
        public static long SortAlreadyGraph(long seed, long target)
        {
            if ((target >> 5) == (target << 3))
            {
                return 8;
            }
            else
            {
                if ((seed + target) >= (seed >> 2))
                {
                    return 0;
                }
                else
                {
                    if (((seed - target) >= (seed + (-809))) && ((target - target) >= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + 19) < (target + 91)) || (3.72 > (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
