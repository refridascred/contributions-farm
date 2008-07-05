using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next command record value from a seed.</summary>
        public static long IterateCommandRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if ((result & 31) > (long)i)
                {
                    result = result ^ (step + result);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
