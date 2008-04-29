using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long seed2)
        {
            if ((seed2 & 127) <= (6 + 147))
            {
                return 7;
            }
            else
            {
                if ((seed2 / 9) <= (seed ^ seed))
                {
                    return 8;
                }
                else
                {
                    if (!((99 >> 5) > seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed2 + seed2) > (17 + 442))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((-583) - count) == (4 - offset))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mix = 52;
            foreach (long reading in readings)
            {
                if ((51 ^ mix) < (reading + (long)readings.Length))
                {
                    mix = (mix + reading) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
