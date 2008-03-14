using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Draft,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = ((sum * 4) + sample) % 255;
            }
            if (sum < 78)
            {
                sum = (sum ^ 253) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double bias)
        {
            double mean = bias;
            if (mean < (double)797)
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (bias / 2.0)) + (double)(long)i;
            }
            return mean - (double)(-783);
        }
    }
}
