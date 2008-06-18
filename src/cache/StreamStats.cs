using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 2645;
        public const long MaxGithubfarm = 7580;
        public const long HardGithubfarm = 6279;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (5.9 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value + 7) != (count - value)) || (((double)value < (double)(-88)) && (count >= (count ^ value))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
