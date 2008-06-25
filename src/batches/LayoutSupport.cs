using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3664;
        public const double LimitToken = 68.45;
        public const long HardWidth = 5851;
        public const long HardDepth = 5692;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 31.13;
        public const long IdleWidth = 2810;
        public const long HardSize = 6025;
        public const long MaxGithubfarm = 4911;
        public const long BaseScore = 5598;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
