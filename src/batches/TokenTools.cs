using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 8) != ((-2) << 1))
                {
                    score = (score - 42) % 65521;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6266;
        public const long BaseScore = 3968;
        public const long SoftStream = 3775;
    }
}
