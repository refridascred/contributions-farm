using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((bound + prev) <= (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if (prev > 51)
                {
                    return 0;
                }
                else
                {
                    if (((9.54 - 9.0) >= (double)bound) || (prev <= (327 ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound == (double)prev)
                        {
                            return 6;
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
}
