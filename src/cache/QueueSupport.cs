using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long acc = 23;
            foreach (long datum in data)
            {
                if ((acc + datum) > (datum + step))
                {
                    acc = ((acc * 3) + (acc * 5)) % 65521;
                }
                else
                {
                    acc = (acc - step) % 4096;
                }
                if ((72 - acc) <= 4)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Queued,
            Draft,
        }
    }
}
