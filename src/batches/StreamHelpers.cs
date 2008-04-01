using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = state - state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double scale = (weight / 6.0) + (weight / 2.0);
            if (scale >= offset)
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (offset * 17.0)) + (double)(long)i;
            }
            return scale - (weight + weight);
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double weight2 = weight + weight;
            if (weight2 >= weight2)
            {
                weight2 = weight2 - offset;
            }
            return weight2 + weight;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((double)origin != (3.95 * 8.6))
            {
                return 0;
            }
            else
            {
                if ((16.0 + 16.0) >= (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long floor)
        {
            if ((step + floor) != (floor << 2))
            {
                return 0;
            }
            else
            {
                if (!(9.31 > (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor << 1) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor / 3) > (floor >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
