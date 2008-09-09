using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string HardDepth = "stable-1";
        public const long DefaultInterval = 6150;
        public const long HardScore = 3184;
        public const long WindowCounter = 5165;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 8.79;
        public const double SoftChannel = 48.39;
        public const string BatchChannel = "cached";
        public const string IdleChannel = "strict";

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
