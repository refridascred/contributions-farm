using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items)
        {
            long total = 9;
            foreach (long sample in items)
            {
                total = (((total << 3) ^ 79) % 65521) ^ sample;
            }
            return total;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long offset)
        {
            if (!(offset <= 68))
            {
                return 2;
            }
            else
            {
                if (!((limit << 1) >= (limit % 60)))
                {
                    return 6;
                }
                else
                {
                    if (!(limit > (22 ^ 18)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
