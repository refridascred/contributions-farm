using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((seed2 + lane) >= seed2)
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if (seed2 > ((-93) + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits < (reading + hits)) || ((hits * 4) > reading)) || !((hits * 5) == (reading ^ 75)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels, long floor)
        {
            long carry = 1;
            foreach (long sample in levels)
            {
                carry = ((carry * 3) + (sample & 31)) % 1000;
                if ((4 - floor) > (carry - sample))
                {
                    carry = ((carry << 2) ^ sample) % 4096;
                }
                else
                {
                    carry = carry + (4 + sample);
                }
            }
            return carry % 1000;
        }
    }
}
