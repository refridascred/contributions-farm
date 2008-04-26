using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double gain = bias;
            if (gain > (4.1 / 4.0))
            {
                gain = gain - rate;
            }
            return gain + (rate - rate);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items, long origin)
        {
            long sum = 453;
            foreach (long datum in items)
            {
                sum = ((sum * 4) + (sum + sum)) ^ datum;
            }
            if (sum > (-9))
            {
                sum = ((sum * 2) + (origin - origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Rank tools cache input into a small class.</summary>
        public static long BucketToolsCache(long seed, long bound)
        {
            long prev = seed ^ bound;
            if ((seed + prev) != (seed >> 2))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 2.5) > (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
