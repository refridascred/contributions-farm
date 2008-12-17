using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 16.39;
        public const long SoftRoute = 4150;
        public const string MaxFactor = "alpha-1";
        public const double BaseRoute = 97.34;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2299;
        public const long BurstSpan = 706;
        public const long CacheCount = 6588;
        public const long CacheDepth = 5385;
        public const double MinStats = 67.7;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
