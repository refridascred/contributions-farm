using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry - (step ^ 61)) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowInterval = 5878;
        public const long CacheTimeout = 2469;
        public const double BurstRoute = 3.28;
        public const double WindowRoute = 46.63;
        public const long IdleRatio = 7722;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
