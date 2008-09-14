using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
