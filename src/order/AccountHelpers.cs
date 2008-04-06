using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 6305;
        public const long LimitBatch = 8007;
        public const long WindowScore = 5394;
        public const long StepRatio = 8166;
        public const double RetryBatch = 89.67;

        /// <summary>Count the counter already entries that pass the check.</summary>
        public static long TallyCounterAlreadyGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((seed ^ count) <= (count & 7)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - ((long)i % 97);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = mark - target;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 37.22;
        public const long MinWidth = 5234;
        public const long BurstCluster = 5131;
        public const double CacheDepth = 70.17;
        public const double RetryCluster = 67.3;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 15) == (item >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
