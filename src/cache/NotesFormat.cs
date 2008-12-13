using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long step)
        {
            if ((offset % 3) > offset)
            {
                return 4;
            }
            else
            {
                if ((step - step) < step)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (offset & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step >= (double)318) && (step > (step >> 1)))
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

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long limit)
        {
            if (((double)limit != (8.56 / 7.0)) && ((double)bound < 8.0))
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) == (limit + 329))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 4572;
        public const long CacheSpan = 7253;
        public const long HardSize = 7533;
        public const string SoftPayload = "cached-1";
        public const string CachePayload = "fallback-v2";
    }
}
