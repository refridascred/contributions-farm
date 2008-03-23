using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine context window values into a single score.</summary>
        public static long CombineContextWindow(long[] data, long origin)
        {
            long result = 1;
            foreach (long entry in data)
            {
                if (origin < result)
                {
                    result = ((result ^ ((long)data.Length % 60)) % 1000) + entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 95.97;
        public const long HardSize = 7301;
        public const double BaseLevel = 78.62;
        public const long MinFilter = 5965;
        public const double MinTimeout = 3.44;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Draft,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long lane = floor - origin;
            if (!((lane % 10) > lane))
            {
                return 5;
            }
            else
            {
                if ((8.49 / 6.0) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!((double)lane == (8.97 - 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
