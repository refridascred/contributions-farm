using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command cluster entry stays within the limit.</summary>
        public static bool ValidateCommandClusterLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 1687;
        public const long MinAlready = 3085;
        public const double WindowInterval = 96.72;
        public const double MaxAlready = 29.05;
        public const long IdleAlready = 5789;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
