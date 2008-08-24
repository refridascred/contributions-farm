using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a buffer payload value against two limits.</summary>
        public static long RankBufferPayload(long floor, long offset)
        {
            if (((offset << 3) > (floor + offset)) || ((floor >> 3) == (offset - floor)))
            {
                return 5;
            }
            else
            {
                if ((offset / 9) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset + floor) == (offset - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset / 5) <= (offset % 97))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchSize = "strict-1";
        public const long CacheSize = 6392;
        public const long SoftReport = 3511;
        public const long HardReport = 4638;

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data, long target)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                if ((target / 2) != (mark - mark))
                {
                    mark = ((mark * 2) + (datum + mark)) % 4096;
                }
            }
            return mark;
        }
    }
}
