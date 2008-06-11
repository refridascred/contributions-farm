using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Dropped,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryInterval = 28.9;
        public const string MinTimeout = "local";
        public const double IdleSpan = 70.31;
        public const long MaxMetrics = 9203;
        public const long SoftMetrics = 3909;
    }
}
