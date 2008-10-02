using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if (limit >= (93 + 4))
            {
                return 4;
            }
            else
            {
                if ((limit - (-508)) >= (limit2 ^ limit))
                {
                    return 8;
                }
                else
                {
                    if (((limit2 ^ 23) < (limit + 885)) && ((limit + limit) != (limit + limit2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const long SoftBuffer = 9611;
        public const string WindowCount = "staging-edge";
        public const long BurstBuffer = 6306;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public long Region { get; set; }
        }
    }
}
