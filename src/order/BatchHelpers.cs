using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)bound <= (6.17 - 17.0)) && !((-3) <= (long)values.Length))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstScore = 3733;
        public const long BatchLevel = 1017;
        public const long LimitInterval = 5022;
        public const string BatchEntry = "open-v2";
        public const long RetryEntry = 538;
    }
}
