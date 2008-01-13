using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 3194;
        public const long IdleWidth = 8182;
        public const double MaxSize = 66.78;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading ^ reading) != (hits << 2)) && ((reading / 3) > (hits * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 3815;
        public const long BatchSpan = 3349;
        public const long StepContributi = 3450;
        public const string LimitContributi = "open";
    }
}
