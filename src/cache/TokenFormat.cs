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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
