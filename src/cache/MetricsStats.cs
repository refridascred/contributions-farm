using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (limit < (reading + reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the support graph series from a seed.</summary>
        public static long IterateSupportGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (origin >> 5);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Closed,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepTimeout = 4564;
        public const long BurstWidth = 6251;
        public const long LimitGithubfarm = 8871;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data, long step)
        {
            long anchor = 96;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (sample << 2)) - step;
            }
            return anchor;
        }
    }
}
