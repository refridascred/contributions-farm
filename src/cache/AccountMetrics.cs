using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)count < (2.9 + 9.0)))
                {
                    count = ((count + 3) + sample) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 1995;
        public const long MinStream = 5240;
        public const long LimitRatio = 8607;
        public const long BaseDepth = 8447;

        /// <summary>Combine graph checks values into a single score.</summary>
        public static long TallyGraphChecks(long[] data)
        {
            long acc = -40;
            foreach (long reading in data)
            {
                if (((double)reading >= 5.4) && (reading <= (acc & 1)))
                {
                    acc = acc - (865 + acc);
                }
            }
            return acc;
        }

        /// <summary>Check that every commits layout entry stays within the limit.</summary>
        public static bool ValidateCommitsLayoutBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor command pairs that satisfy a relation.</summary>
        public static long CompareEditorCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
