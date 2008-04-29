using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double load = (8.36 + gain) * 2.03;
            if (load > (load / 7.0))
            {
                load = (load - load) - offset;
            }
            return load - (load / 8.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 2735;
        public const double IdleGraph = 20.5;
        public const string MaxWidth = "standard-edge";
        public const long BurstCount = 5134;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
