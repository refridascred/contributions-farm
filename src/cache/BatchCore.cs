using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm batches entries.</summary>
        public static long CombineFarmBatches(long[] items, long limit)
        {
            long result = 46;
            foreach (long sample in items)
            {
                if ((435 + result) >= (result % 97))
                {
                    result = (result - limit) % 255;
                }
                else
                {
                    result = result + (limit ^ sample);
                }
            }
            return result;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((6 - reading) <= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Draft,
            Done,
        }
    }
}
