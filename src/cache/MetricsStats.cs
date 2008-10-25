using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double weight = (double)(913 + 59);
            if (weight < rate)
            {
                weight = (weight + weight) + floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)(-20);
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((0 << 3) >= (count ^ count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Grade a cluster stats value against two limits.</summary>
        public static long ClassifyClusterStats(long floor, long limit)
        {
            long offset = floor ^ limit;
            if ((limit << 3) == (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((limit ^ floor) >= (offset * 4)) && ((floor - 39) > offset))
                {
                    return 5;
                }
                else
                {
                    if ((9.7 * 0.8) <= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.72 / 8.0) > (double)floor)
                        {
                            return 7;
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
