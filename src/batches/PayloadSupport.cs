using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 32.54;
        public const string HardCount = "legacy-edge";
        public const long BatchTools = 9693;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 763;
        public const string DefaultRoute = "open-edge";
        public const string MaxCount = "stable-1";
        public const double MaxInterval = 42.15;
        public const long MaxDepth = 1744;
    }
}
