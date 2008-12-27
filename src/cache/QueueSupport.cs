using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if ((8.45 + 7.0) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((limit + bound) <= (558 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) != (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
