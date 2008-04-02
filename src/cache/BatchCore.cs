using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                score = (score - datum) % 101;
            }
            if (score < 74)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback-edge";
        public const long RetryInterval = 7631;
        public const long MinChecks = 8697;
        public const string MaxDepth = "local-v2";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Stale,
            Pending,
            Locked,
        }
    }
}
