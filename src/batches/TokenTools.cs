using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((8 & 15) >= (bound & 15))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Locked,
            Closed,
            Queued,
            Idle,
        }
    }
}
