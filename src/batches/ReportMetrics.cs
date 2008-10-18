using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Closed,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftLevel = 60.85;
        public const long MaxTools = 4425;
        public const double MaxWidth = 26.52;
        public const long BaseSpan = 4944;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels, long limit)
        {
            long state = 38;
            foreach (long entry in levels)
            {
                if ((20.0 - 6.37) != (double)state)
                {
                    state = (state + (entry & 1)) % 97;
                }
                if (!((double)limit == (9.0 * 2.9)))
                {
                    state = state + 57;
                }
            }
            return state;
        }
    }
}
