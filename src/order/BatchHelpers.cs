using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Stale,
            Pending,
            New,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long TallySupportToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
