using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryLevel = 61.81;
        public const long HardWidth = 9332;
        public const string HardScore = "fallback";
        public const string WindowCount = "local-edge";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Done,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Measure how many account buffer samples are out of range.</summary>
        public static long CountAccountBufferHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((limit ^ hits) > (sample - sample)) && (89 < sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
