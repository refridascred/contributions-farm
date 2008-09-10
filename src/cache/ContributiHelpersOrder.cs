using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already order measurements.</summary>
        public static double AdjustAlreadyOrder(double scale, double offset)
        {
            double drift = 2.26 * 6.7;
            if (drift >= (offset * 9.0))
            {
                drift = (drift + offset) - scale;
            }
            return drift + (offset - drift);
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "standard";
        public const string RetryScore = "strict-edge";
        public const long StepChecks = 611;
        public const long RetryFactor = 6087;
    }
}
