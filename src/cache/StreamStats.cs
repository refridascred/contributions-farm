using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if ((seed >= cur) || ((5 << 1) >= (cur ^ seed2)))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (8.0 - 1.34))
                {
                    return 4;
                }
                else
                {
                    if (((double)cur == (12.0 * 9.3)) && (cur < (seed2 + 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed2 << 2) < seed2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double offset)
        {
            double drift = gain - (gain - gain);
            return (drift - (double)6) + offset;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long carry = 720;
            foreach (long entry in data)
            {
                carry = (carry - (origin & 63)) ^ entry;
                if ((83 % 12) <= (carry - 560))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
