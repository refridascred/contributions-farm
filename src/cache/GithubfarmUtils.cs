using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double scale = (8.9 + 9.23) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale + (double)22) + (double)(long)i) + weight) - span;
            }
            return scale - (double)5;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double mean = gain;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + 8.54) + (double)(long)i) + offset;
            }
            return mean + (double)66;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up order stream samples.</summary>
        public static long CompareOrderStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
