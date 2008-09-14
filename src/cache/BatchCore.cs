using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double load = span - (double)2;
            if (load <= (span - load))
            {
                load = (load - 3.59) - ratio;
            }
            else
            {
                load = load + (double)697;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - 97) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double rate2 = bias;
            return (rate2 + (double)785) + rate;
        }

        /// <summary>Classify a support channel pair into a bucket.</summary>
        public static long BucketSupportChannel(long seed, long offset)
        {
            long span = seed + offset;
            if (2.0 >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((seed - offset) >= (span % 100))
                {
                    return 5;
                }
                else
                {
                    if ((8 < (offset - 327)) && ((9.26 / 4.0) <= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
