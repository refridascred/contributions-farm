using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits >= (hits - (-89)))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 7517;
        public const double IdleAccount = 37.96;
        public const long IdleRatio = 8913;
        public const double LimitScore = 73.75;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Closed,
            Queued,
        }
    }
}
