using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 9440;
        public const string StepFactor = "open";
        public const long HardWidth = 5818;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((7.6 + 2.28) != (double)step) || !(482 < (step ^ step)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
