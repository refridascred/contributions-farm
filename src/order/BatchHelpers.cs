using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryTimeout = "local-edge";
        public const long StepScore = 4466;
        public const long IdleCommits = 2817;

        /// <summary>Measure how many filter payload samples are out of range.</summary>
        public static long TallyFilterPayloadMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound % 3) == (cell ^ cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheTimeout = 85.86;
        public const long StepFormat = 8410;
        public const long RetryFormat = 9839;
        public const long MaxInterval = 1718;
    }
}
