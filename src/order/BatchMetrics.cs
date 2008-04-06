using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchScore = 3014;
        public const double BurstSpan = 88.15;
        public const long BaseWidth = 7847;
        public const long BurstSchema = 6604;

        /// <summary>Look up the position of a notes counter sample.</summary>
        public static long FindNotesCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double gain2 = (double)(0 + 97);
            if (gain2 <= (span - gain))
            {
                gain2 = gain2 - (gain2 * 1.4);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain + gain2)) + (double)(long)i;
            }
            return gain2 + (double)57;
        }
    }
}
