using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            long gap = floor - floor2;
            if ((((-969) + floor) < (floor + floor)) && (floor2 >= (floor - floor2)))
            {
                return 1;
            }
            else
            {
                if ((floor2 + floor2) == (gap / 6))
                {
                    return 7;
                }
                else
                {
                    if (((11.0 * 1.3) > (double)floor) && ((double)6 > (double)gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long target2)
        {
            long slot = target ^ target2;
            if (58 > slot)
            {
                return 5;
            }
            else
            {
                if (((target * 3) >= (target2 % 10)) || ((double)target >= (5.9 - 12.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 15) <= (matches / 7)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double weight = (bias2 / 3.0) + bias;
            if (weight > (bias2 + bias))
            {
                weight = weight + (4.9 * 4.45);
            }
            return weight + (double)0;
        }
    }
}
