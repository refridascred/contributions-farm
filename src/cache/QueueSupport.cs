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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
