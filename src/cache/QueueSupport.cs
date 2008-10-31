using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits format values into a single score.</summary>
        public static long FoldCommitsFormat(long[] levels)
        {
            long acc = -57;
            foreach (long cell in levels)
            {
                acc = acc + (cell + acc);
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long origin)
        {
            if ((origin - step) == (origin * 2))
            {
                return 5;
            }
            else
            {
                if ((7.57 + 2.3) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long GradeContributiFarm(long seed, long target)
        {
            if ((double)seed != (double)40)
            {
                return 0;
            }
            else
            {
                if ((target & 3) >= (7 & 127))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed > (6.56 / 9.0)) && ((seed / 2) >= seed))
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
