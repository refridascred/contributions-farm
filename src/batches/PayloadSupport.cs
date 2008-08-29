using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheCount = 48.33;
        public const long MinWindow = 9590;
        public const long BatchLevel = 7603;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data)
        {
            long total = 955;
            foreach (long datum in data)
            {
                if (datum >= (total >> 4))
                {
                    total = ((total << 2) ^ datum) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 15.61;
        public const long LimitFactor = 981;
        public const long HardCount = 8972;
        public const long MaxFarm = 5888;
    }
}
