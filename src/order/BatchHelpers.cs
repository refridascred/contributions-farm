using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Failed,
            Idle,
            New,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen < (double)cell)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Failed,
            Retry,
        }
    }
}
