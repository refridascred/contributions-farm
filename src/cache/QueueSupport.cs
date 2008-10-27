using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Paused,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Check that every batches graph entry stays within the limit.</summary>
        public static bool ValidateBatchesGraphLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Draft,
            Ready,
            Synced,
            Queued,
        }
    }
}
