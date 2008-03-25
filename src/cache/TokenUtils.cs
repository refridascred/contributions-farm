using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long target)
        {
            long cur = limit ^ target;
            if (((double)cur >= (double)target) || ((limit % 7) <= (target * 2)))
            {
                return 2;
            }
            else
            {
                if ((cur + cur) > (target << 3))
                {
                    return 7;
                }
                else
                {
                    if ((254 & 1) != (cur - 534))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)target <= 15.0))
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
    }
}
