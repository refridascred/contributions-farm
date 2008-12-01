using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell ^ seen) <= ((long)values.Length - seen)) || ((double)seen != (5.64 + 1.43)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultTimeout = 4687;
        public const long MaxLevel = 7836;
        public const string MinStats = "latest-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 5223;
        public const double BatchSize = 11.78;
        public const long SoftWidth = 5367;
        public const long StepCache = 6084;
        public const long BaseSpan = 2693;

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] samples, long offset)
        {
            long sum = 362;
            foreach (long item in samples)
            {
                if ((item + (long)samples.Length) > offset)
                {
                    sum = (sum ^ (item - item)) % 255;
                }
            }
            if (sum < 4)
            {
                sum = (sum << 3) ^ (offset / 4);
            }
            return sum;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next buffer counter value.</summary>
        public static double AdjustBufferCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > (9.63 + bias2))
            {
                bias2 = bias2 + span;
            }
            return bias2 + (double)2;
        }
    }
}
