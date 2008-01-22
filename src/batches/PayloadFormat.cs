using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + limit) == (605 - 1))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate entry command readings against a bound.</summary>
        public static bool CheckEntryCommandBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 549;
        public const string MaxLevel = "cached";
        public const long WindowRatio = 7088;
        public const long MaxWidth = 5778;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 5492;
        public const string RetryCounter = "standard";
        public const string BurstSpan = "stable";
        public const long MinInterval = 7952;
        public const string DefaultCounter = "latest-v2";
    }
}
