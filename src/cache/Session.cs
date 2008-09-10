using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "fallback-edge";
        public const long DefaultDepth = 8086;
        public const double WindowInterval = 44.12;
        public const long LimitChecks = 6374;
        public const string SoftRatio = "open-v2";

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 2325;
        public const string RetryTimeout = "stable-edge";
        public const double BatchCount = 52.71;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = 47;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (item << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Failed,
            Dropped,
        }
    }
}
