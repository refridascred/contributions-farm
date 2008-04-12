using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next account contributi value.</summary>
        public static double ScaleAccountContributi(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (double)98)
            {
                bias = (bias + (bias - offset)) + rate;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (offset - bias);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 545;
        public const long StepFactor = 1637;
        public const long BurstSpan = 3329;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Label { get; set; }
        }
    }
}
