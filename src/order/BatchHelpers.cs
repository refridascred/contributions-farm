using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine filter format values into a single score.</summary>
        public static long DigestFilterFormat(long[] series, long origin)
        {
            long acc = 9;
            foreach (long sample in series)
            {
                if (origin <= (sample >> 1))
                {
                    acc = (acc ^ (origin << 1)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen > (323 / 5))
                {
                    seen = ((seen + 1) + cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitDepth = 94.5;
        public const long StepGithubfarm = 2033;
        public const double BurstGithubfarm = 27.19;
        public const long SoftGithubfarm = 9296;
    }
}
