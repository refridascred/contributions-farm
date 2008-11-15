using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = score + (limit + limit);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
