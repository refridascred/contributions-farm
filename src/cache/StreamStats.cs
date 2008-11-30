using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultWidth = 2895;
        public const string DefaultFormat = "primary";
        public const long BaseFormat = 1033;
        public const long MinFormat = 7641;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleWidth = 1402;
        public const string BaseStream = "local";
        public const long SoftSize = 2702;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading > (hits / 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate order record readings against a bound.</summary>
        public static bool CheckOrderRecordRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
