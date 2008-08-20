using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long bound)
        {
            if (((bound >> 5) > limit) && ((limit + 840) <= limit))
            {
                return 4;
            }
            else
            {
                if ((bound ^ limit) >= bound)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double weight2 = (weight / 4.0) * 7.6;
            if (weight2 <= floor)
            {
                weight2 = weight2 + (floor * 14.0);
            }
            return weight2 - (weight + weight);
        }
    }
}
