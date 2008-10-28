using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "latest-edge";
        public const long SoftNotes = 3375;
        public const long StepNotes = 2222;
        public const long RetryNotes = 9896;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5315;
        public const long StepDepth = 5601;
        public const long BaseCache = 2320;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                long delta = (offset + result) - (offset << 2);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result - (delta + delta)) % 255) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] items, long origin)
        {
            long mix = 14;
            foreach (long reading in items)
            {
                mix = ((mix ^ (2 ^ 466)) % 1000) + reading;
            }
            if (mix < 5)
            {
                mix = mix ^ (origin / 7);
            }
            return mix;
        }
    }
}
