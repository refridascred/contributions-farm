using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 59.44;
        public const string SoftStats = "alpha-v2";
        public const double WindowStats = 13.67;
        public const long BurstStats = 6929;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values, long step)
        {
            long sum = -766;
            foreach (long datum in values)
            {
                sum = (sum ^ step) - datum;
            }
            return sum % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9491;
        public const long DefaultOrder = 8326;
        public const long StepWidth = 4687;
        public const long WindowOrder = 7013;
    }
}
