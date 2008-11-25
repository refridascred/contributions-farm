using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxSize = "primary-edge";
        public const long LimitCount = 8718;
        public const string SoftReport = "latest-1";
        public const string WindowReport = "cached";
        public const long RetryInterval = 4689;
    }
}
