using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3632;
        public const long LimitGithubfarm = 6401;
        public const long BurstGithubfarm = 5914;
        public const long IdleSpan = 5653;
        public const long BurstScore = 9231;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long target)
        {
            if ((3.3 + 6.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((7 / 8) > step)
                {
                    return 3;
                }
                else
                {
                    if ((step * 3) > (3 + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
