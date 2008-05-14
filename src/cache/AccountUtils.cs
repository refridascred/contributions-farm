using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long carry = 892;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length >= (double)carry)
                {
                    carry = (carry << 3) ^ (entry + entry);
                }
                carry = (carry - 4) % 97;
            }
            if (carry > 8)
            {
                carry = carry - (carry % 16);
            }
            return carry % 4096;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev - prev) >= (offset - floor))
            {
                return 5;
            }
            else
            {
                if (((56 >> 5) > offset) && ((double)prev != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (prev < (offset >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((6 - prev) >= (822 >> 1)) && ((offset % 64) == (prev ^ prev)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally - 2) > (tally ^ reading)) && ((reading + reading) >= 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
