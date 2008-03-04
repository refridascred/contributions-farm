using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
