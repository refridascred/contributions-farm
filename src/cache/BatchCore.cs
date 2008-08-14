using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of checks payload readings.</summary>
        public static long DigestChecksPayload(long[] levels)
        {
            long total = 4;
            foreach (long value in levels)
            {
                total = (total ^ (value + total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Measure how many payload layout samples are out of range.</summary>
        public static long MeasurePayloadLayoutOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((20.0 + 5.7) == (double)offset))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
