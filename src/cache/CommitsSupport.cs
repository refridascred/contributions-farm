using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long bound)
        {
            if (62 >= (2 + limit))
            {
                return 1;
            }
            else
            {
                if (limit < 93)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardScore = "local-edge";
        public const long IdleBatches = 7594;
        public const double MinSize = 52.03;
        public const long DefaultSize = 228;

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 28;
            foreach (long item in items)
            {
                if ((item % 5) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 101;
                    carry = carry ^ carry;
                }
                if ((item + item) >= item)
                {
                    carry = carry ^ (carry % 16);
                }
                if (((double)(-37) <= (double)item) && ((item + carry) > (item / 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 89.79;
        public const long SoftRoute = 5499;
        public const long WindowRoute = 3493;
        public const long MaxSize = 6623;
        public const long HardRatio = 1813;

        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long IterateBatchGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 2) ^ (seed + seed)) % 97;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
