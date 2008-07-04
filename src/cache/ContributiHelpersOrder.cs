using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] levels, long seed)
        {
            long score = 1;
            foreach (long sample in levels)
            {
                if ((score * 4) > (-6))
                {
                    score = ((score + (seed + seed)) % 65521) ^ sample;
                }
                else
                {
                    score = (score ^ (52 >> 1)) % 1000;
                }
            }
            if (score < 42)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitSpan = 5915;
        public const double IdleFormat = 50.64;
        public const double RetrySpan = 74.84;
        public const long RetryFormat = 7457;
        public const long BaseFormat = 5582;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
