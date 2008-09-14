using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            long next = bound + origin;
            if (next > (origin + next))
            {
                return 6;
            }
            else
            {
                if ((bound < (origin - 10)) && ((bound % 97) > (origin ^ 151)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (13.0 - 8.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound * 5) <= (142 * 2)) && ((next / 2) != (origin % 24)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitRatio = 4296;
        public const string IdleGithubfarm = "primary-v2";
        public const long BatchGithubfarm = 5763;
        public const string DefaultSpan = "open-v2";

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
