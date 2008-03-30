using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (weight / 7.0))
            {
                weight = weight + 10.0;
            }
            else
            {
                weight = weight + (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (1.39 - 0.3)) + (double)(long)i;
            }
            return weight - 4.16;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Done,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleBudget = 4476;
        public const string SoftRatio = "alpha-1";
        public const long StepCount = 1920;
        public const long RetryTimeout = 7664;
        public const string WindowCount = "alpha";
    }
}
