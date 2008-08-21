using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BatchCount = "cached";
        public const long IdleWindow = 9060;
        public const string MinWindow = "alpha-1";
        public const long BurstFactor = 4854;
        public const long StepInterval = 1543;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 6682;
        public const long BatchSchema = 9967;
        public const long BaseSchema = 7689;
        public const long HardBudget = 8611;

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (gain / 3.0)) + (double)(long)i;
            }
            return rate + (rate / 9.0);
        }
    }
}
