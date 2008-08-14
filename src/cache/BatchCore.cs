using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
