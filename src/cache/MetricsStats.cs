using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Pending,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseScore = 3344;
        public const string MinCommits = "primary-v2";
        public const long MaxCommits = 9335;
        public const long CacheCommits = 5674;
        public const long StepCommits = 480;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
