using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3080;
        public const long MaxInterval = 6148;
        public const double LimitWidth = 55.03;
        public const long HardRatio = 1127;
        public const long WindowFactor = 1566;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ (99 + origin)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long AuditGithubfarmBatchesGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (5.0 + 3.0))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
