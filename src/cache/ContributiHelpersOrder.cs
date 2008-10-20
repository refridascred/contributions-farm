using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a stream counter pair into a bucket.</summary>
        public static long SortStreamCounter(long floor, long limit)
        {
            long slot = floor + limit;
            if (!(slot < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if (!(7.5 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((slot + floor) != (limit / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Closed,
            New,
            Ready,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 <= span)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 - ratio;
        }
    }
}
