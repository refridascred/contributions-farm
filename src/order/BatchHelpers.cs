using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryInterval = 55.13;
        public const string RetryScore = "latest";
        public const long SoftInterval = 7592;
        public const double DefaultQueue = 97.15;

        /// <summary>Rank tools report input into a small class.</summary>
        public static long GradeToolsReport(long limit, long step)
        {
            if (!((2 ^ step) != (3 + 890)))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 2) == (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step & 127) != (limit - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
