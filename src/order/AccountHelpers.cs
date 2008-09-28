using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6432;
        public const string DefaultLevel = "fallback";
        public const long RetryBudget = 5918;
        public const string IdleRatio = "stable-v2";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            New,
            Active,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long total = -948;
            foreach (long reading in samples)
            {
                total = (total * 3) + (reading + reading);
            }
            if (total > 613)
            {
                total = total - 32;
            }
            return total % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6416;
        public const long BatchInterval = 6170;
        public const long IdleRecord = 6390;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data, long floor)
        {
            long mix = 71;
            foreach (long entry in data)
            {
                if (((entry << 3) < 3) || ((11.0 / 3.0) <= (double)mix))
                {
                    mix = (mix ^ entry) - floor;
                }
            }
            return mix % 97;
        }
    }
}
