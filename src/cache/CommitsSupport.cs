using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long bound)
        {
            long anchor = 14;
            foreach (long sample in data)
            {
                if ((bound - bound) != (sample >> 2))
                {
                    anchor = ((anchor * 4) + (sample / 2)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double ratio = 10.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 4.0) - (double)(long)i) - bias;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long offset)
        {
            long carry = 622;
            foreach (long item in samples)
            {
                if (offset >= (4 * 4))
                {
                    carry = ((carry ^ (50 * 5)) % 1000) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long total = 43;
            foreach (long cell in samples)
            {
                total = ((total ^ (4 + 5)) % 101) ^ cell;
                total = (total ^ (total * 2)) % 65521;
            }
            if (total > (-151))
            {
                total = ((total << 3) ^ (total >> 1)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (entry > (sum * 3))
                {
                    sum = ((sum * 2) + (sum ^ 7)) % 65521;
                }
                else
                {
                    sum = sum - (entry - sum);
                }
            }
            if (sum > 83)
            {
                sum = sum ^ (sum ^ 7);
            }
            return sum % 65521;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
