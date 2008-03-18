using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchWidth = "alpha";
        public const long RetryEntry = 9031;
        public const string IdleEntry = "latest";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (double)1)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 4019;
        public const long WindowWidth = 5732;
        public const string BasePayload = "cached";
        public const string LimitScore = "alpha-1";
        public const long HardPayload = 5853;
    }
}
