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

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 9073;
        public const long MinRatio = 2581;
        public const long MaxLevel = 6902;
        public const string DefaultScore = "staging-v2";
    }
}
