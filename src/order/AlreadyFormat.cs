using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9636;
        public const double MinDepth = 22.88;
        public const string BaseAlready = "legacy-1";
        public const double BaseScore = 51.76;
        public const double IdleAlready = 25.18;

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long step)
        {
            long sum = 41;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((((sum * 5) + step) % 255) + (long)i) + item;
                }
                if ((step - sum) < sum)
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
                else
                {
                    sum = sum - (40 * 4);
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
