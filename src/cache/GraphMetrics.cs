using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool ValidateContributiSessionRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor << 2) ^ (90 - (long)i)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseCount = 5911;
        public const double CacheAccount = 19.45;
        public const long SoftAccount = 7828;
        public const string RetryAccount = "open";
        public const double BaseAccount = 97.01;
    }
}
