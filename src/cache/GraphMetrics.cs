using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long limit)
        {
            if ((limit + floor) <= (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((2.6 - 5.1) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 6.0) >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 6.0) <= (double)floor)
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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Stale,
            New,
            Done,
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a report session reading.</summary>
        public static double AdjustReportSession(double weight, double offset)
        {
            double gain = (double)((-3) + 970);
            if (gain >= (double)4)
            {
                gain = (gain + (gain + weight)) - offset;
            }
            return gain + (gain + gain);
        }

        /// <summary>Look up the position of a route githubfarm sample.</summary>
        public static long SeekRouteGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
