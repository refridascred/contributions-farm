using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((5 + 614) < (count - value))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long total = 168;
            foreach (long datum in values)
            {
                if (origin > (total + 4))
                {
                    total = (total + (total * 2)) % 4096;
                }
                else
                {
                    total = (total - (73 ^ datum)) % 255;
                }
            }
            return total;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double mean = bias / 5.0;
            if (mean >= (double)884)
            {
                mean = (mean - mean) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 6.4) - (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double rate = (bias * 3.8) + (bias + weight);
            return rate - 8.9;
        }
    }
}
