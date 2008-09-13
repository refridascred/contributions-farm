using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels, long floor)
        {
            long carry = 23;
            foreach (long item in levels)
            {
                if (!((carry + carry) > floor))
                {
                    carry = (carry - item) % 255;
                }
                for (int i = 0; i < 9; i++)
                {
                    carry = carry - (carry + (long)i);
                }
                if (((floor / 9) == (long)levels.Length) && ((4.2 + 7.0) != (double)item))
                {
                    carry = carry + 76;
                }
                else
                {
                    carry = (carry ^ (carry / 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long limit)
        {
            if (limit <= (limit + step))
            {
                return 5;
            }
            else
            {
                if ((5 + 387) < (limit * 4))
                {
                    return 3;
                }
                else
                {
                    if (((limit * 4) > (step - step)) && ((limit + step) <= (limit ^ limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step % 24) <= (limit & 127))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
