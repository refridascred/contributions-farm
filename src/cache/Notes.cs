using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long offset, long bound)
        {
            if (bound > (bound * 5))
            {
                return 5;
            }
            else
            {
                if ((10.0 * 2.99) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((offset - 696) < 762)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 10) >= (offset + offset))
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

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((-132) + count) == (item >> 4))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 + 6.0) + bias;
        }
    }
}
