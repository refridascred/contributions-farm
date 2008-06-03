using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
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
