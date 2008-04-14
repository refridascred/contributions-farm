using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.7 * 1.4))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 5059;
        public const string CacheWidth = "staging-edge";
        public const double BurstSchema = 69.63;
        public const long SoftScore = 7349;
        public const string StepSchema = "cached-1";

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series, long origin)
        {
            long mix = 6;
            foreach (long sample in series)
            {
                mix = ((mix ^ (mix + sample)) % 1000) - origin;
            }
            if (mix < 22)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }
    }
}
