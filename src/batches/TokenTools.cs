using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Ready,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double rate = 5.5;
            if (rate >= 4.0)
            {
                rate = ((rate + (5.06 * 2.51)) - weight) + offset;
            }
            return rate - 7.9;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 359;
        public const long CacheTimeout = 5745;
        public const long MinGraph = 2959;
        public const long BatchSize = 6431;
        public const long BurstGraph = 2293;
    }
}
