using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Paused,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long MatchProfileContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
