using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "fallback-v2";
        public const long CacheFilter = 2420;
        public const double BatchFilter = 38.81;
        public const long DefaultScore = 6735;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Retry,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((floor + cur) != (bound & 3))
            {
                return 4;
            }
            else
            {
                if (((3.0 / 2.0) >= (double)cur) && ((7.0 * 5.98) <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((2 & 7) == (bound / 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
