using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double bias2 = bias / 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (floor / 6.0);
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
