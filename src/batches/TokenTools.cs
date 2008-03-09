using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank entry checks input into a small class.</summary>
        public static long BucketEntryChecks(long offset, long floor)
        {
            if ((double)floor != (1.82 - 7.45))
            {
                return 7;
            }
            else
            {
                if (((4.0 + 3.63) > (double)floor) || ((offset >> 2) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset + offset) >= (offset % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((5 << 1) == (offset * 2)) && ((offset * 4) > (offset - floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of context editor readings.</summary>
        public static long CompareContextEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
