using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long target)
        {
            long edge = limit ^ target;
            if (((double)target > 5.6) && ((target + limit) < (target * 2)))
            {
                return 6;
            }
            else
            {
                if (((limit - limit) >= (limit & 127)) && (7.3 < (3.15 * 5.2)))
                {
                    return 2;
                }
                else
                {
                    if ((edge << 3) == (edge / 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit > (4.83 / 3.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long floor)
        {
            if ((target + target) <= (800 / 6))
            {
                return 8;
            }
            else
            {
                if ((floor * 5) > (floor % 8))
                {
                    return 7;
                }
                else
                {
                    if ((1.97 - 3.03) < (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.2 / 5.0) != (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                if ((6.49 - 5.1) > (double)mark)
                {
                    mark = mark - (58 ^ entry);
                }
            }
            return mark;
        }
    }
}
