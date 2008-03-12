using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a commits report value against two limits.</summary>
        public static long ClassifyCommitsReport(long step, long offset)
        {
            if ((offset >> 5) >= 56)
            {
                return 1;
            }
            else
            {
                if (!(step < (offset & 255)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Retry,
            Active,
        }
    }
}
