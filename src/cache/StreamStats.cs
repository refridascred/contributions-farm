using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (span + span)) - (double)(long)i) + rate;
            }
            return ratio + span;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double rate = bias;
            if (rate >= (5.16 - 6.7))
            {
                rate = (rate + bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - 1.0;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long floor, long step)
        {
            long cur = floor - step;
            if ((cur ^ floor) != (floor * 4))
            {
                return 6;
            }
            else
            {
                if ((step - 2) <= 865)
                {
                    return 3;
                }
                else
                {
                    if ((step << 1) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
