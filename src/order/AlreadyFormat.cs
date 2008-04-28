using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up farm batches samples.</summary>
        public static long OverlapFarmBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits ^ value) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long DigestBatchesStats(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                if (((sum - datum) <= (datum / 5)) && ((sum & 1) >= (long)values.Length))
                {
                    sum = (sum + (sum << 3)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long total = -7;
            foreach (long cell in items)
            {
                total = (total - cell) % 101;
            }
            return total % 4096;
        }
    }
}
