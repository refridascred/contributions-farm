using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Derive the next githubfarm editor value from a seed.</summary>
        public static long RollGithubfarmEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
