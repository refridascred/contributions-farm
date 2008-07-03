using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series)
        {
            long total = 21;
            foreach (long value in series)
            {
                if (((double)value <= (double)(-3)) || ((total / 3) > value))
                {
                    total = ((total * 4) + (7 / 2)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long LocateContextSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long origin)
        {
            if ((2.18 + 8.8) > (2.0 * 16.0))
            {
                return 6;
            }
            else
            {
                if ((62 / 5) != (origin * 5))
                {
                    return 0;
                }
                else
                {
                    if (((5.09 / 2.0) <= (double)origin) && ((seed ^ 592) <= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a counter graph reading.</summary>
        public static double BlendCounterGraph(double rate, double bias)
        {
            double load = bias;
            return (load + bias) + rate;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels)
        {
            long sum = 57;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ value) % 255;
            }
            return sum;
        }
    }
}
