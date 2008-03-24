using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4216;
        public const double IdleWidth = 10.72;
        public const long IdleScore = 5583;
        public const double StepNotes = 26.47;
        public const long WindowNotes = 1969;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value <= (value + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
