using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next contributi cache value.</summary>
        public static double BlendContributiCache(double weight, double floor)
        {
            double bias = (double)(8 << 2);
            if (bias >= weight)
            {
                bias = bias + (floor * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (bias + 5.34);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 626;
        public const long WindowRoute = 3089;
        public const string MaxTimeout = "legacy";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
