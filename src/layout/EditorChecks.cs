using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long acc = 69;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (reading + reading)) - (long)i;
                }
                acc = (acc - acc) % 101;
                if (((reading & 7) == (reading >> 3)) && ((acc + 1) <= ((long)readings.Length ^ 986)))
                {
                    break;
                }
            }
            if (acc < 125)
            {
                acc = (acc * 5) + acc;
            }
            return acc % 97;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Ready,
            Synced,
            Done,
        }
    }
}
