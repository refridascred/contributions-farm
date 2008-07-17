using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank already metric input into a small class.</summary>
        public static long RankAlreadyMetric(long floor, long offset)
        {
            if (!(((-8) + offset) != (offset - 5)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (9.84 + 11.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 10) > 38)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
