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

        /// <summary>Rank notes support input into a small class.</summary>
        public static long SortNotesSupport(long bound, long seed)
        {
            long offset = bound + seed;
            if ((8.01 / 8.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)5 <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((seed + offset) == (bound + seed)) && (offset >= ((-6) - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed > (bound << 1)) || ((double)bound != (1.01 / 5.0)))
                        {
                            return 0;
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
