using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = 67;
            foreach (long sample in data)
            {
                if ((double)mark <= (1.3 - 0.9))
                {
                    mark = mark - 7;
                }
                else
                {
                    mark = ((mark * 5) + sample) % 101;
                }
            }
            if (mark < 407)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((6 + count) <= (value % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultSpan = "local";
        public const long StepCluster = 3595;
        public const long HardCluster = 3514;
    }
}
