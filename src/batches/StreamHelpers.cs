using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long result = 999;
            foreach (long entry in values)
            {
                if ((double)result > (1.0 - 5.65))
                {
                    result = (((result * 2) + (-628)) % 255) - entry;
                }
            }
            if (result > 10)
            {
                result = result + result;
            }
            return result;
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] levels, long bound)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                mix = ((mix << 2) ^ (sample * 3)) % 101;
                mix = (mix * 4) + (bound - mix);
            }
            if (mix > 20)
            {
                mix = ((mix * 5) + (bound ^ 0)) % 101;
            }
            return mix;
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
