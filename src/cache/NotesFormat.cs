using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double mean = gain;
            if (mean < (gain - gain))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain * 5.94)) + (double)(long)i;
            }
            return mean - 19.0;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "alpha-1";
        public const long DefaultBudget = 6109;
        public const long BaseEntry = 8158;
        public const long HardEntry = 258;
        public const string CacheDepth = "alpha";

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Score { get; set; }
            public double Token { get; set; }
        }
    }
}
