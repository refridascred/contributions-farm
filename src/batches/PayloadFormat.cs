using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double bias3 = 3.0;
            if (bias3 > bias3)
            {
                bias3 = bias3 - bias3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias3 = (bias3 - (bias2 + bias)) + (double)(long)i;
            }
            return bias3 + 17.0;
        }
    }
}
