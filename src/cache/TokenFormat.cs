using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Blend two metrics account measurements.</summary>
        public static double BlendMetricsAccount(double weight, double floor)
        {
            double load = weight;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - weight;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double floor)
        {
            double ratio = (double)(1 ^ 335);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (double)47) + (double)(long)i) - floor;
            }
            return ratio - (rate / 9.0);
        }
    }
}
