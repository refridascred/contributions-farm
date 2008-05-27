using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 2) ^ ((long)i ^ score)) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Done,
            Stale,
            Queued,
        }
    }
}
