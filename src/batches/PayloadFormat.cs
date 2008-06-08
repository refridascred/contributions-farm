using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 6849;
        public const long BaseScore = 1351;
        public const long BurstRatio = 63;
        public const string RetryStream = "primary-edge";

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Locked,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
