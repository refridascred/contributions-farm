using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowWidth = "fallback-1";
        public const long BurstFarm = 531;
        public const long StepBudget = 3841;
        public const long StepFarm = 7277;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= ((long)samples.Length + 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
