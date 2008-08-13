using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6162;
        public const long SoftCommits = 3595;
        public const long CacheSize = 3212;
        public const double RetryCommits = 41.93;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    mark = (mark - ((long)i + 73)) ^ (long)i3;
                }
                if ((mark + (long)i) >= (target >> 4))
                {
                    mark = (mark * 4) + (420 / 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
