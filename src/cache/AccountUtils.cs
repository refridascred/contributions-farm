using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "strict-edge";
        public const double WindowRatio = 88.21;
        public const long MinRatio = 6087;
        public const long CacheInterval = 4057;
        public const string BaseSize = "primary-v2";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
