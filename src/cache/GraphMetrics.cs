using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardWidth = 40.98;
        public const long MaxOrder = 2105;
        public const long WindowOrder = 347;
        public const long MinOrder = 8511;
        public const double StepTimeout = 45.1;

        /// <summary>Fold a list of cache githubfarm readings.</summary>
        public static long ScoreCacheGithubfarm(long[] series)
        {
            long sum = 16;
            foreach (long value in series)
            {
                sum = ((sum * 3) + 446) - value;
            }
            if (sum < (-63))
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }
    }
}
