using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 75.24;
        public const long BaseTimeout = 1275;
        public const string CachePayload = "local-v2";

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long carry = 65;
            foreach (long cell in data)
            {
                if ((12 & 1) < (cell << 1))
                {
                    carry = carry ^ (bound + cell);
                }
                else
                {
                    carry = ((carry << 2) ^ (long)data.Length) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (offset - hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
