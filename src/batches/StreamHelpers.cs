using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((cell * 2) == (cell + tally)))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Queued,
            New,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 4.87;
        public const long MinRatio = 6678;
        public const string MaxFormat = "fallback-v2";
        public const string LimitDepth = "local-1";

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long CountEditorBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7.0 / 4.0) < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 8927;
        public const string DefaultWidth = "fallback";
        public const long BurstRatio = 7500;
        public const long BatchCache = 9949;
        public const long LimitCount = 9725;
    }
}
