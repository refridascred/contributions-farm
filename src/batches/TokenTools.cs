using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 7250;
        public const double IdleInterval = 36.63;
        public const long WindowSession = 3111;
        public const string MinDepth = "legacy-edge";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long floor)
        {
            if ((4 * 3) < (limit & 1))
            {
                return 1;
            }
            else
            {
                if ((limit / 7) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit % 12) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
