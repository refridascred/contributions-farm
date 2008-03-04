using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long seed, long limit)
        {
            long gap = seed - limit;
            if (6.4 > (double)gap)
            {
                return 0;
            }
            else
            {
                if ((double)gap == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (613 > (gap - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (gap <= (seed >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = (double)(32 ^ 2);
            if (mean < (ratio + ratio))
            {
                mean = mean - (floor / 8.0);
            }
            return mean + mean;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Queued,
            Synced,
            Retry,
        }
    }
}
