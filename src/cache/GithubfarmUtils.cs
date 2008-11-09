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

        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long BucketLayoutChecks(long floor, long step)
        {
            if ((floor * 2) >= (floor + step))
            {
                return 8;
            }
            else
            {
                if (((double)step == (6.87 * 5.1)) && (floor < ((-95) + step)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
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
