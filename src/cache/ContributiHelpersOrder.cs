using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine record filter values into a single score.</summary>
        public static long FoldRecordFilter(long[] samples)
        {
            long mark = 6;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + mark) % 255) ^ entry;
                if (!((double)mark != (16.0 - 7.18)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
