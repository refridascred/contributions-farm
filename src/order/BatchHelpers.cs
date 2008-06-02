using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many counter notes samples are out of range.</summary>
        public static long CountCounterNotesGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value <= (matches % 16))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Draft,
            Closed,
            Pending,
        }
    }
}
