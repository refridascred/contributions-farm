using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings)
        {
            long mix = 40;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ (entry - 4)) % 65521;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 729;
        public const long BatchSession = 2948;
        public const long WindowSpan = 4814;
        public const long LimitScore = 6058;
        public const long BaseDepth = 6681;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetrySize = 1856;
        public const long LimitBatches = 9860;
        public const long CacheBatches = 5441;
        public const string WindowInterval = "open-edge";

        /// <summary>Blend two payload editor measurements.</summary>
        public static double ScalePayloadEditor(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)458)
            {
                bias3 = (bias3 + (double)92) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 + (double)2) + (double)(long)i;
            }
            return bias3 + 9.7;
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((count + 35) > (1 & 31)) && (item < 76)) && ((count ^ count) <= (item + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the commits githubfarm entries that pass the check.</summary>
        public static long MeasureCommitsGithubfarmHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!((seen + (-8)) > (6 + 3)))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
