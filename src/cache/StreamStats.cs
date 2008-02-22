using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] series)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if (!((double)result > (9.0 + 2.0)))
                {
                    result = ((result + 48) % 101) + reading;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a profile layout sample.</summary>
        public static long SeekProfileLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long offset, long floor)
        {
            long next = offset ^ floor;
            if (offset <= (next / 9))
            {
                return 1;
            }
            else
            {
                if ((15.0 - 1.8) != (double)next)
                {
                    return 4;
                }
                else
                {
                    if (!((offset << 2) <= floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (next - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double span)
        {
            double load = bias;
            if (load >= span)
            {
                load = load - (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span / 5.0)) - (double)(long)i;
            }
            return load - 5.1;
        }
    }
}
