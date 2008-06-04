using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Paused,
            Pending,
            Dropped,
            Idle,
        }
    }
}
