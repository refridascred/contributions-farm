using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheSpan = 88.73;
        public const long BatchWidth = 6610;
        public const long MaxWindow = 1963;
        public const long MinWindow = 4379;

        /// <summary>Measure how many entry support samples are out of range.</summary>
        public static long TallyEntrySupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally ^ 447) > (tally & 127)) || ((double)value > (4.6 + 1.8)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5544;
        public const long SoftPayload = 2685;
        public const long HardPayload = 4080;
        public const string RetryPayload = "stable-v2";
    }
}
