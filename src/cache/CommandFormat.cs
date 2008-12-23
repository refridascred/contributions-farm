using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 1944;
        public const long HardCount = 462;
        public const string MinEntry = "latest-edge";

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7005;
        public const long BurstBuffer = 9989;
        public const long DefaultDepth = 4009;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (floor <= (hits + floor))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }
    }
}
