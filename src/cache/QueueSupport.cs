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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            New,
            Stale,
            Paused,
            Active,
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
