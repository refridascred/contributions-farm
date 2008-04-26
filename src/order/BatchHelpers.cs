using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the schema metrics entries that pass the check.</summary>
        public static long MeasureSchemaMetricsMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((((double)sample != (7.9 + 9.1)) && ((double)sample < 0.2)) && ((target % 16) >= (target * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((237 - origin) == (30 + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 69.61;
        public const long RetryGithubfarm = 4999;
        public const long WindowGithubfarm = 3291;
        public const long BatchCount = 2664;
    }
}
