using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double load = floor / 4.0;
            return (load + (double)435) + bias;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long floor)
        {
            long span = seed + floor;
            if ((double)span >= (7.0 - 6.9))
            {
                return 7;
            }
            else
            {
                if (!(seed >= ((-9) + 557)))
                {
                    return 5;
                }
                else
                {
                    if (((seed << 1) == ((-66) & 15)) && ((double)floor < (double)span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)span <= (double)(-9)) || ((floor * 3) > seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                acc = ((acc * 3) + (acc >> 5)) + entry;
            }
            if (acc < 65)
            {
                acc = (acc - (acc << 3)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 3471;
        public const double IdleTimeout = 43.0;
        public const long CacheBatches = 6149;
        public const long BatchCount = 3728;
    }
}
