using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinSize = "latest";
        public const double SoftTimeout = 95.09;
        public const string LimitBudget = "primary-edge";
        public const string MaxCluster = "primary-edge";

        /// <summary>Grade a editor cluster value against two limits.</summary>
        public static long GradeEditorCluster(long limit, long floor)
        {
            if (floor >= limit)
            {
                return 3;
            }
            else
            {
                if (0 <= (limit << 2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 1356;
        public const string HardProfile = "latest-v2";
        public const string LimitWidth = "legacy-v2";
        public const double MinDepth = 67.85;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((3.3 - 5.26) >= (double)step)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultTimeout = "primary-v2";
        public const string MinRatio = "stable-edge";
        public const long RetryScore = 2235;
        public const long BaseInterval = 1563;
    }
}
