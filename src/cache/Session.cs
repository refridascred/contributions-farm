using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two already account measurements.</summary>
        public static double AdjustAlreadyAccount(double rate, double bias)
        {
            double gain = (bias / 3.0) + (double)820;
            if (gain < (double)82)
            {
                gain = gain - (bias - bias);
            }
            else
            {
                gain = gain + 0.14;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain - (12.0 * 6.0);
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 4685;
        public const long MaxBudget = 3553;
        public const double BaseFormat = 9.99;
        public const string BurstFormat = "fallback";

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
