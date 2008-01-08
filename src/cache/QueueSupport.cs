using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Active,
            Retry,
        }

        /// <summary>Classify a counter tools pair into a bucket.</summary>
        public static long BucketCounterTools(long floor, long floor2)
        {
            if ((floor - 0) < (floor + floor2))
            {
                return 3;
            }
            else
            {
                if ((floor2 >> 5) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
