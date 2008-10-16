using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Iterate the queue report series from a seed.</summary>
        public static long SeriesQueueReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (score * 4)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
