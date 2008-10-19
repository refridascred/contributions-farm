using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const string SoftStream = "stable-v2";
        public const string MinCount = "latest-1";
        public const long HardCount = 7985;
        public const double IdleStream = 84.31;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "staging-edge";
        public const string SoftScore = "alpha";
        public const double BaseReport = 21.93;
        public const double DefaultReport = 46.02;
        public const double IdleReport = 74.17;
    }
}
