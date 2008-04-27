using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 5750;
        public const long HardSize = 7360;
        public const long LimitFormat = 882;
        public const string BatchFormat = "cached";
        public const long CacheFormat = 2432;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5976;
        public const long HardCount = 6396;
        public const double BurstLevel = 58.63;

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long CombineFormatGithubfarm(long[] values)
        {
            long state = -2;
            foreach (long reading in values)
            {
                state = ((state * 3) + (reading % 5)) % 97;
                if ((state >> 2) < ((long)values.Length << 3))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long FoldEntryBatch(long[] samples, long limit)
        {
            long state = 61;
            foreach (long cell in samples)
            {
                state = (((state << 2) ^ state) - cell) + limit;
            }
            if (state < 1)
            {
                state = state + (89 - state);
            }
            return state;
        }
    }
}
