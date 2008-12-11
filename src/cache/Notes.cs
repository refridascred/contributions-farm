using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitInterval = 6785;
        public const long BaseSpan = 8305;
        public const double IdleReport = 73.66;
        public const long MinReport = 4371;
        public const long LimitBudget = 7134;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
