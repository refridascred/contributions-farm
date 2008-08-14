using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Done,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry - target) <= (target - 50)) && ((9.99 + 2.23) >= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
