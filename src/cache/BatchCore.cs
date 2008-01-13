using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Locked,
            Done,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleCount = 68.6;
        public const double SoftSpan = 16.57;
        public const long DefaultNotes = 5323;
        public const long BatchNotes = 4519;
        public const double MaxTimeout = 71.54;
    }
}
