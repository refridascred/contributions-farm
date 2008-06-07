using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxCount = 4781;
        public const double WindowReport = 42.69;
        public const long SoftReport = 2298;
        public const double LimitFactor = 35.9;
        public const double RetryFactor = 7.71;

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
