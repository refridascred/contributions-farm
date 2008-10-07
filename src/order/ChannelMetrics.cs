using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format cache value from a seed.</summary>
        public static long IterateFormatCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + (anchor / 7);
                if (!((4.6 / 9.0) <= (double)seed))
                {
                    anchor = anchor ^ (anchor - seed);
                }
                anchor = (anchor + ((long)i << 1)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double scale2 = scale - bias;
            if (scale2 <= (2.5 / 8.0))
            {
                scale2 = scale2 + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (6.24 + scale)) + (double)(long)i;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long floor, long offset)
        {
            long slot = floor + offset;
            if ((offset + offset) < (offset - 83))
            {
                return 2;
            }
            else
            {
                if (slot >= (20 - slot))
                {
                    return 7;
                }
                else
                {
                    if ((floor ^ slot) <= offset)
                    {
                        return 3;
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
