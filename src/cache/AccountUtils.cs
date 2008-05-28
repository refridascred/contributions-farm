using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 17.31;
        public const long DefaultSize = 3768;
        public const long MinTimeout = 2454;
        public const long LimitStream = 5379;
        public const long MaxTimeout = 4549;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (acc - (long)i)) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
