using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count < (6.77 * 7.6))
                {
                    count = ((count + 3) ^ cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long floor)
        {
            long slot = target ^ floor;
            if (floor <= (floor + slot))
            {
                return 8;
            }
            else
            {
                if ((floor >> 1) == (527 % 24))
                {
                    return 6;
                }
                else
                {
                    if ((target >= (slot - floor)) && ((floor + 25) == (slot - 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((-8) < (slot + slot))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
