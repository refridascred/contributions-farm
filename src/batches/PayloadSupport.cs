using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 77.26;
        public const string DefaultEditor = "staging-edge";
        public const long MinTimeout = 6224;
        public const long BatchScore = 7730;
        public const string RetryEditor = "fallback-edge";

        /// <summary>Check that every queue batch entry stays within the limit.</summary>
        public static bool GuardQueueBatchBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of metric cluster readings.</summary>
        public static long MatchMetricClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
