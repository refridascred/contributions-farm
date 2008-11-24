using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Active,
            New,
            Failed,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Pending,
            Closed,
        }
    }
}
