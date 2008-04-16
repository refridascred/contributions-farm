using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double load = (double)39 * 9.92;
            if (load <= 1.0)
            {
                load = load - (4.3 + load);
            }
            else
            {
                load = load - (span + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (8.4 / 9.0)) + (double)(long)i;
            }
            return load + (span / 7.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 8953;
        public const long HardSupport = 6621;
        public const double MaxSize = 1.86;
        public const string CacheInterval = "stable-edge";
    }
}
