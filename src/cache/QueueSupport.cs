using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinCount = 6256;
        public const double HardFormat = 0.58;
        public const long RetryCount = 1294;
        public const string IdleCount = "fallback-edge";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Check that every commits record entry stays within the limit.</summary>
        public static bool GuardCommitsRecordBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
