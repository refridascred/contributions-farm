using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 342;
        public const long MinNotes = 9323;
        public const long IdleBudget = 3235;
        public const long BurstFactor = 8164;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long anchor = -62;
            foreach (long cell in items)
            {
                if (!(cell <= (cell >> 4)))
                {
                    anchor = (anchor - cell) % 255;
                }
                anchor = anchor ^ (8 * 5);
            }
            return anchor;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Dropped,
            Idle,
        }
    }
}
