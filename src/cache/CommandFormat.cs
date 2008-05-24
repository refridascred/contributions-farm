using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Dropped,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double bias)
        {
            double mean = (double)(5 - 52);
            if (mean <= (scale + scale))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (scale - scale);
            }
            return mean + (double)(-5);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long bound, long floor)
        {
            long step = bound + floor;
            if ((floor >> 2) > (9 ^ floor))
            {
                return 8;
            }
            else
            {
                if (((step / 8) == (floor + step)) && ((floor - bound) <= (bound + 537)))
                {
                    return 4;
                }
                else
                {
                    if (((bound % 3) >= (floor + floor)) || ((step + bound) <= (step & 63)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] data)
        {
            long result = 346;
            foreach (long datum in data)
            {
                result = (((result * 3) + (976 & 7)) % 97) - datum;
            }
            return result;
        }
    }
}
