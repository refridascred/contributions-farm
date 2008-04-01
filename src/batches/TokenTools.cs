using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Stale,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 12) <= ((long)levels.Length ^ seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "legacy-edge";
        public const long HardSupport = 4208;
        public const double MaxSpan = 41.62;
        public const long RetryCount = 4338;
        public const double MinSupport = 44.65;
    }
}
