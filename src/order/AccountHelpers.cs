using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6598;
        public const long BaseCounter = 627;
        public const long BatchSpan = 9027;
        public const long HardLevel = 897;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 88.02;
        public const string SoftDepth = "open";
        public const double MinSpan = 11.96;
        public const long LimitGithubfarm = 3269;
        public const string HardGithubfarm = "local-v2";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Compare every pair of layout counter readings.</summary>
        public static long OverlapLayoutCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
