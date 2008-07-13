using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double ratio = (double)((-10) / 2);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) - weight;
            }
            return ratio - (double)19;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardWidth = "legacy-edge";
        public const long MinSpan = 302;
        public const long IdleContributi = 7056;
        public const long MinContributi = 7304;
        public const long CacheWidth = 4773;
    }
}
