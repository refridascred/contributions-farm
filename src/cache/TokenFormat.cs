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

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
