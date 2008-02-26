using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 5786;
        public const double BurstLevel = 1.28;
        public const long BatchGithubfarm = 2287;

        /// <summary>Roll a schema counter counter forward.</summary>
        public static long DeriveSchemaCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
