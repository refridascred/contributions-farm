using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = score - (limit << 3);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
