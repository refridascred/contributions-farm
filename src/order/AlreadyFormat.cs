using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the session window series from a seed.</summary>
        public static long IterateSessionWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long target2)
        {
            long step = target - target2;
            if ((target * 4) == (step - target2))
            {
                return 8;
            }
            else
            {
                if (target < (target2 >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((target2 * 5) > (target2 + target2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a metric record value against two limits.</summary>
        public static long BucketMetricRecord(long floor, long seed)
        {
            if ((double)282 <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((10.0 + 9.1) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - tally) > (cell + cell))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
