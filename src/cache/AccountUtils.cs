using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a stats tools reading by value.</summary>
        public static long LocateStatsToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                if (!(value > (mix - 642)))
                {
                    mix = ((mix << 2) ^ (mix >> 3)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a filter command value against two limits.</summary>
        public static long BucketFilterCommand(long limit, long step)
        {
            long gap = limit + step;
            if ((limit + gap) < (limit & 31))
            {
                return 2;
            }
            else
            {
                if (((gap + limit) > 641) || ((step + gap) >= (step / 2)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit < 1.1)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
