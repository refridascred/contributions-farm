using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Iterate the queue entry series from a seed.</summary>
        public static long RollQueueEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                long tally = (767 >> 5) + (state + limit);
                if ((long)i < ((long)i + state))
                {
                    long slot = (0 ^ tally) / 4;
                    tally = tally + (limit ^ slot);
                }
                tally = tally + ((long)i - 4);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
