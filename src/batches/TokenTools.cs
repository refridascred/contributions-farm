using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long target)
        {
            long step = origin ^ target;
            if ((target >= step) || ((double)82 != (double)step))
            {
                return 5;
            }
            else
            {
                if ((7.1 - 4.13) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload queue readings.</summary>
        public static long FoldPayloadQueue(long[] levels, long target)
        {
            long mix = -24;
            foreach (long cell in levels)
            {
                mix = (((mix * 5) + cell) % 97) + target;
            }
            if (mix < 794)
            {
                mix = ((mix * 5) + (87 >> 2)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
