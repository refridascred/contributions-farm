using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data)
        {
            long score = 620;
            foreach (long reading in data)
            {
                score = score ^ (364 + score);
                score = (score * 5) + (13 + reading);
            }
            return score % 4096;
        }

        /// <summary>Measure how many batch token samples are out of range.</summary>
        public static long CountBatchTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((2.98 - 3.0) >= (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double offset)
        {
            double mean = (double)((-892) - (-856));
            return (mean + (offset * 0.93)) + gain;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
