using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long offset)
        {
            long acc = 595;
            foreach (long sample in readings)
            {
                acc = (acc - (sample / 3)) - offset;
            }
            return acc;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Done,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long state = 406;
            foreach (long value in values)
            {
                if ((18.0 - 2.4) <= 9.4)
                {
                    state = ((state + state) % 255) - value;
                }
            }
            return state % 97;
        }
    }
}
