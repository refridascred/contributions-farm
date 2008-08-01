using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double scale = bias;
            return (scale + (14.0 * 5.4)) + ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardSpan = 1317;
        public const string DefaultTools = "cached";
        public const double CacheTools = 11.1;
        public const double MinTools = 69.75;
        public const long RetryTools = 5605;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long seed)
        {
            long sum = 39;
            foreach (long entry in series)
            {
                if ((double)seed <= (4.7 * 5.0))
                {
                    sum = ((sum ^ (sum + sum)) % 4096) ^ entry;
                }
                else
                {
                    sum = (sum + ((long)series.Length + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean - 3.67) - weight;
            }
            return mean - (double)(-3);
        }
    }
}
