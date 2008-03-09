using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long limit)
        {
            long anchor = -84;
            foreach (long cell in data)
            {
                if (!((1 ^ limit) <= (limit * 5)))
                {
                    anchor = (anchor + (cell % 12)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxLevel = 77.92;
        public const double WindowWidth = 48.46;
        public const string SoftCounter = "standard-v2";

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Stale,
        }
    }
}
