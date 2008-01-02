using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
