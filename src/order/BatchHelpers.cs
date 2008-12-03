using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Active,
            Paused,
            Closed,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long AuditEditorChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((6.07 * 8.55) != (double)tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
