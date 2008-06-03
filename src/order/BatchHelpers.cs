using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 5694;
        public const long CacheEditor = 6337;
        public const long DefaultEditor = 8183;
        public const double IdleInterval = 7.43;

        /// <summary>Combine payload order values into a single score.</summary>
        public static long ScorePayloadOrder(long[] samples, long bound)
        {
            long score = 47;
            foreach (long item in samples)
            {
                score = (score + (score + score)) % 65521;
                if ((bound * 5) > score)
                {
                    score = (score + (item % 16)) % 101;
                }
            }
            return score;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
