using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Pending,
            Paused,
        }
    }
}
