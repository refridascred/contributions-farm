using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((carry + carry) >= carry)
                {
                    carry = ((carry ^ reading) % 65521) + offset;
                }
            }
            return carry;
        }
    }
}
