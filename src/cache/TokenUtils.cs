using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ 6) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score - offset) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
