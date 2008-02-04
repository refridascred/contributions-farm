using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Failed,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 5544;
        public const long CacheSize = 4473;
        public const long StepCluster = 4306;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 1024;
        public const string DefaultTools = "latest-1";
        public const long CacheTools = 6631;
        public const long StepTools = 8223;

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
