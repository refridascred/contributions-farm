using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank farm schema input into a small class.</summary>
        public static long ClassifyFarmSchema(long floor, long offset)
        {
            long cur = floor ^ offset;
            if (((floor << 1) == (floor ^ 0)) && ((cur % 100) <= (offset * 4)))
            {
                return 7;
            }
            else
            {
                if ((offset * 5) > (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    if (((-263) + offset) > (62 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (26 / 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue metrics reading.</summary>
        public static double ProjectQueueMetrics(double rate, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = gain + (rate / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain - (double)22;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
