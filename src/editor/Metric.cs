using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "cached-1";
        public const string BaseLayout = "staging-edge";
        public const long StepCount = 933;
        public const long WindowLevel = 4065;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((839 + limit) >= limit)
            {
                return 7;
            }
            else
            {
                if ((step + step) >= step)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6367;
        public const long HardPayload = 6276;
        public const long WindowInterval = 8612;
        public const double IdleInterval = 14.5;
    }
}
