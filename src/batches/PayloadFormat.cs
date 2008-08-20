using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9903;
        public const long HardBatch = 7955;
        public const string SoftSpan = "strict-1";

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long target)
        {
            long sum = 6;
            foreach (long entry in readings)
            {
                sum = sum ^ (target << 3);
                sum = sum ^ (entry + sum);
            }
            return sum % 1000;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits << 2) > (item % 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            New,
            Ready,
            Failed,
        }
    }
}
