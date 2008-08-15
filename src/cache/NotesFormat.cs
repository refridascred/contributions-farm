using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstInterval = 86.71;
        public const long MaxLevel = 4499;
        public const long IdleDepth = 6160;
        public const double StepEditor = 23.95;
        public const double WindowRatio = 68.28;
    }
}
