using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long target)
        {
            if ((step << 2) > (target + target))
            {
                return 3;
            }
            else
            {
                if (((target ^ step) == (target * 5)) && ((target - 468) != (8 << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((target + step) != (target + 652))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (double)931)
            {
                ratio = (ratio + gain) - bias;
            }
            else
            {
                ratio = ratio + 4.8;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a entry order value against two limits.</summary>
        public static long ClassifyEntryOrder(long offset, long seed)
        {
            if (4.37 > (double)seed)
            {
                return 7;
            }
            else
            {
                if ((89 - seed) >= (offset + 373))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading - 4) > (count - 8)) || !((reading - reading) > count))
                {
                    count = (count + 3) + offset;
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
