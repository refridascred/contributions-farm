using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine checks support values into a single score.</summary>
        public static long TotalChecksSupport(long[] samples)
        {
            long result = 49;
            foreach (long item in samples)
            {
                result = (result ^ 1) + item;
            }
            return result;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double bias = (rate / 3.0) / 5.0;
            if (bias >= rate)
            {
                bias = (bias + rate) - offset;
            }
            return bias + (7.0 / 3.0);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Failed,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Done,
            Retry,
        }
    }
}
