using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9309;
        public const long MaxInterval = 5027;
        public const double CacheReport = 34.74;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 108;
        public const long SoftChannel = 1306;
        public const long HardChannel = 2348;
        public const long DefaultRatio = 6249;
        public const string MaxChannel = "standard";
    }
}
