using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            if ((8.0 - 11.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin & 63) < (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if ((5.65 + 9.2) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double mean = 0.1;
            return (mean + weight) + span;
        }

        /// <summary>Rank graph session input into a small class.</summary>
        public static long GradeGraphSession(long floor, long floor2)
        {
            long lane = floor ^ floor2;
            if (floor > (lane / 8))
            {
                return 4;
            }
            else
            {
                if ((5.02 + 20.0) == (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((double)lane > (14.0 * 0.21))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 - floor) > (floor2 << 3))
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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long AuditFarmOrderHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= 1.8)
                {
                    count = ((count + 1) - value) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
