using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long origin)
        {
            long bound = seed - origin;
            if (!((double)origin <= (9.7 * 6.77)))
            {
                return 1;
            }
            else
            {
                if (((bound + seed) < 104) && ((seed / 5) > origin))
                {
                    return 0;
                }
                else
                {
                    if (((seed + origin) == (9 & 3)) || ((seed ^ bound) >= (origin & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)seed >= (6.3 / 7.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Pending,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - seen) > (reading / 6))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
