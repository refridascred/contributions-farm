using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the token githubfarm series from a seed.</summary>
        public static long RollTokenGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score + ((long)i & 63)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
