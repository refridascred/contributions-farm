using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long floor)
        {
            long diff = seed - floor;
            if (((8.0 + 15.0) != (double)floor) && ((85 & 3) > (diff + seed)))
            {
                return 7;
            }
            else
            {
                if ((double)53 <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((diff + seed) < (12 - diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1.0 / 8.0) != (double)diff) || ((floor + floor) < 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double ScaleFilterEditor(double weight, double bias)
        {
            double scale = (weight - weight) - (double)852;
            if (scale > scale)
            {
                scale = (scale + weight) - bias;
            }
            else
            {
                scale = scale - (double)912;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 5.14)) - (double)(long)i;
            }
            return scale + (scale * 0.14);
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long CombineProfileCounter(long[] data, long origin)
        {
            long acc = 52;
            foreach (long cell in data)
            {
                acc = ((acc << 3) ^ ((long)data.Length + acc)) % 1000;
                if (((cell + origin) < (cell + 306)) && ((double)origin == (1.65 - 4.3)))
                {
                    acc = (acc - (758 / 8)) % 4096;
                }
            }
            return acc;
        }
    }
}
