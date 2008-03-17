using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items, long limit)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if ((double)cell > (8.65 * 5.0))
                {
                    sum = ((sum * 2) + (limit - limit)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Active,
            Ready,
            Queued,
            Failed,
        }
    }
}
