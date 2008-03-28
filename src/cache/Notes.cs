using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long DigestBufferEntry(long[] levels, long bound)
        {
            long result = 5;
            foreach (long datum in levels)
            {
                if (!((result + datum) >= (datum - 76)))
                {
                    result = (result ^ (long)levels.Length) + bound;
                }
            }
            if (result > 243)
            {
                result = (result ^ ((-763) * 4)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi window measurements.</summary>
        public static double AdjustContributiWindow(double ratio, double span)
        {
            double bias = (double)(30 ^ 801);
            if (bias > (double)8)
            {
                bias = (bias - span) - ratio;
            }
            return bias - (16.0 + bias);
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long origin2)
        {
            if ((3.29 * 6.3) <= (double)origin2)
            {
                return 8;
            }
            else
            {
                if ((5.07 <= (double)origin2) || ((origin + origin) < (origin2 + 24)))
                {
                    return 3;
                }
                else
                {
                    if (((13.0 - 8.5) >= 4.41) || ((origin << 1) != (23 << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 5) >= origin2)
                        {
                            return 7;
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
}
