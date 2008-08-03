using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 128;
            foreach (long reading in samples)
            {
                if ((double)carry < (0.8 * 3.92))
                {
                    carry = ((carry - (carry << 1)) % 65521) + reading;
                }
            }
            if (carry > 42)
            {
                carry = carry ^ (carry % 100);
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 7417;
        public const double MaxCache = 90.03;
        public const long MaxCount = 20;
        public const string StepBudget = "alpha-v2";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Queued,
            Retry,
            New,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double ratio = span;
            return (ratio - (double)224) + scale;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
        }
    }
}
