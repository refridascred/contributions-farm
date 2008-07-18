using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long offset)
        {
            if ((49 % 3) == (offset << 3))
            {
                return 4;
            }
            else
            {
                if (((offset % 100) >= (offset % 64)) || ((offset * 5) >= (origin & 31)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin <= (8.0 - 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 432;
        public const long HardBuffer = 6379;
        public const long IdleRatio = 8222;
    }
}
