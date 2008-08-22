using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            if ((bound ^ floor) < bound)
            {
                return 2;
            }
            else
            {
                if (((7 - floor) >= (bound + bound)) || ((963 % 16) > (floor + 12)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + bound) <= (floor * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool CheckNotesProfileBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            if (53 < (635 + origin))
            {
                return 5;
            }
            else
            {
                if ((floor % 97) <= (floor ^ origin))
                {
                    return 4;
                }
                else
                {
                    if (origin > (10 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor & 31) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values, long offset)
        {
            long state = 924;
            foreach (long sample in values)
            {
                if ((2.61 - 10.0) < (double)state)
                {
                    state = ((state ^ (offset / 3)) % 65521) + sample;
                }
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double scale = gain - 7.11;
            if (scale >= scale)
            {
                scale = scale - (span - span);
            }
            else
            {
                scale = scale + (scale * 2.9);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
