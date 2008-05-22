using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next batch stream value from a seed.</summary>
        public static long RollBatchStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor - (step - anchor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3497;
        public const string LimitEntry = "open-edge";
        public const string CacheInterval = "legacy-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitGithubfarm = "cached-edge";
        public const long CacheScore = 1869;
        public const long CacheGithubfarm = 9886;
        public const string RetryFactor = "staging-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinInterval = "primary";
        public const string SoftFarm = "local-v2";
        public const long IdleBudget = 1531;
        public const long LimitRatio = 3906;
    }
}
