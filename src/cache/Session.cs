using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a filter githubfarm sample.</summary>
        public static long LocateFilterGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 2049;
        public const double RetryCache = 35.34;
        public const long WindowDepth = 9484;
        public const long IdleScore = 3965;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
