using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheInterval = 49.94;
        public const double MinRatio = 71.49;
        public const string BatchStream = "open";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = (result + (76 / 6)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxSize = 8.11;
        public const long CacheEditor = 8351;
        public const double MaxEditor = 21.76;
        public const long WindowEditor = 656;
    }
}
