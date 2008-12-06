using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double span)
        {
            double ratio = scale - (span + span);
            if (ratio >= (scale + span))
            {
                ratio = ratio + (ratio + ratio);
            }
            return ratio + (scale * 15.0);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long limit)
        {
            if ((4.8 / 9.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((bound + bound) >= bound) && ((bound + 6) < (limit << 2)))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) <= (bound + limit)) || ((0.14 - 7.43) > (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4 + 3) <= (bound * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if ((item <= (carry - carry)) && ((item - item) != (carry ^ carry)))
                {
                    carry = (carry + carry) % 255;
                }
            }
            return carry;
        }
    }
}
