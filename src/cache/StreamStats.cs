using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 9073;
        public const long MinRatio = 2581;
        public const long MaxLevel = 6902;
        public const string DefaultScore = "staging-v2";
    }
}
