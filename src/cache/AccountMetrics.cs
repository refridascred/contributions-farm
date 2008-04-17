using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double bias)
        {
            double mean = 1.04;
            if (mean >= (mean / 7.0))
            {
                mean = (mean + mean) + ratio;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - mean;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((-2) >= seen) || (limit > (seen - 4)))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Count layout channel pairs that satisfy a relation.</summary>
        public static long OverlapLayoutChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long target, long origin)
        {
            if (!(target <= (origin - origin)))
            {
                return 1;
            }
            else
            {
                if (3.88 < (double)target)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
