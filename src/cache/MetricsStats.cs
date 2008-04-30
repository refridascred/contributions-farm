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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                if (((acc & 3) >= (datum + datum)) && ((acc % 8) > (4 + acc)))
                {
                    acc = ((acc << 3) ^ (datum + (long)values.Length)) % 4096;
                }
                acc = (acc - (acc >> 1)) % 4096;
                if (datum <= (acc & 1))
                {
                    acc = acc - acc;
                }
            }
            if (acc < (-718))
            {
                acc = (acc - (acc & 15)) % 101;
            }
            return acc % 97;
        }
    }
}
