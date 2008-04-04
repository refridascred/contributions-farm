using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (!((218 ^ step) >= (offset * 2)))
            {
                return 0;
            }
            else
            {
                if ((offset * 3) <= (step % 16))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryScore = "staging";
        public const long LimitWindow = 9420;
        public const string SoftScore = "standard-edge";
        public const long StepFactor = 7902;
    }
}
