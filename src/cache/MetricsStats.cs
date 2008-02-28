using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((floor >= limit) || (4.0 >= (double)limit))
            {
                return 5;
            }
            else
            {
                if ((floor % 60) < (79 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor != (3.12 * 8.3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long step)
        {
            long prev = offset + step;
            if ((step << 2) < (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((prev - offset) <= 90)
                {
                    return 2;
                }
                else
                {
                    if (6.1 < (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((685 / 8) <= (prev * 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank channel record input into a small class.</summary>
        public static long ClassifyChannelRecord(long bound, long offset)
        {
            if (offset >= (bound / 5))
            {
                return 0;
            }
            else
            {
                if (!(offset < (bound + (-5))))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
