using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long bound)
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

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank support command input into a small class.</summary>
        public static long BucketSupportCommand(long step, long offset)
        {
            if ((192 << 1) <= (step / 4))
            {
                return 6;
            }
            else
            {
                if ((double)offset < (2.1 * 8.4))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) >= (offset * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset < step) || (step < (4 & 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
