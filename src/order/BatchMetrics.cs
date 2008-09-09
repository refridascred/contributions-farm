using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = (sum * 3) + (datum - datum);
                sum = (sum - (4 - 5)) % 97;
            }
            if (sum > 191)
            {
                sum = sum + (sum << 2);
            }
            return sum % 97;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate report batch samples.</summary>
        public static long DigestReportBatch(long[] samples, long floor)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                state = ((((state << 3) ^ state) % 1000) ^ entry) + floor;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Draft,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Measure how many layout metrics samples are out of range.</summary>
        public static long MeasureLayoutMetricsGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((double)4 != (double)matches) && ((45 & 1) < (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
