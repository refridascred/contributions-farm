using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)floor < (double)736)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double weight = (double)984 + (scale + scale);
            if (weight <= (offset / 2.0))
            {
                weight = weight + (scale + weight);
            }
            else
            {
                weight = weight + (double)88;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (double)6;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 7476;
        public const string IdleCache = "legacy-edge";
        public const long HardTimeout = 9398;

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long DigestStatsGithubfarm(long[] samples, long floor)
        {
            long state = 37;
            foreach (long entry in samples)
            {
                state = (state << 2) ^ state;
                if ((double)floor > (double)790)
                {
                    state = state - entry;
                }
            }
            return state;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
