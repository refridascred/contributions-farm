using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxCount = 7754;
        public const long MinRatio = 2809;
        public const string SoftScore = "local";
        public const long SoftWidth = 2751;
        public const double SoftChecks = 4.53;

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items, long seed)
        {
            long state = 899;
            foreach (long datum in items)
            {
                state = (state ^ (state / 2)) - seed;
                if ((double)datum > 4.0)
                {
                    state = state ^ state;
                }
            }
            return state;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (score >> 3)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseFactor = "alpha-1";
        public const long IdleFactor = 3250;
        public const long MinWidth = 804;
        public const long IdleStats = 5712;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
