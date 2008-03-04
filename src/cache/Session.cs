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

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double bias = floor;
            return (bias + (floor / 7.0)) + weight;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Measure how many contributi queue samples are out of range.</summary>
        public static long CountContributiQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((double)tally >= (double)reading) && ((15.0 / 2.0) > (double)reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
