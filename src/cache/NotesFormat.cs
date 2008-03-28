using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate profile metric samples.</summary>
        public static long CombineProfileMetric(long[] data, long seed)
        {
            long acc = 9;
            foreach (long datum in data)
            {
                if ((double)seed >= 5.0)
                {
                    acc = (acc - (4 << 1)) ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Active,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
