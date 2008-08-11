using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long CountBatchMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (6.0 + 10.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a stats schema pair into a bucket.</summary>
        public static long ClassifyStatsSchema(long origin, long bound)
        {
            if ((bound + 232) <= (bound - origin))
            {
                return 2;
            }
            else
            {
                if ((4.07 - 5.7) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((588 - origin) <= (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound != (4.91 - 16.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)(long)data.Length >= 6.51) && ((7 * 2) >= seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] levels, long target)
        {
            long score = 558;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score ^ (target - score)) % 101) ^ (long)i;
                    score = score - (score + 45);
                }
                if (((target + score) >= entry) || ((double)target >= (2.7 * 10.0)))
                {
                    score = (score + entry) % 97;
                }
            }
            if (score < 7)
            {
                score = score ^ (929 + target);
            }
            return score;
        }
    }
}
