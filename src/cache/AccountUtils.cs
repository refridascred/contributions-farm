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

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

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
