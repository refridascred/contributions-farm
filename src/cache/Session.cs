using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3625;
        public const long BatchGithubfarm = 750;
        public const double WindowGithubfarm = 7.04;

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 89.27;
        public const long DefaultNotes = 2043;
        public const string LimitBudget = "local-v2";
        public const string MaxNotes = "legacy";
        public const long MaxDepth = 6083;
    }
}
