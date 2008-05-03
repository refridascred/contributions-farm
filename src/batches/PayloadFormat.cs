using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Pending,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 7709;
        public const long WindowAlready = 2928;
        public const long SoftAlready = 3323;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((target / 2) >= target)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the tools format entries that pass the check.</summary>
        public static long MeasureToolsFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 3) == (sample - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
