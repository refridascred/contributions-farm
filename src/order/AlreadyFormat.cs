using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((1.0 * 1.01) < (double)bound)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long step)
        {
            if ((step >> 2) == ((-6) - offset))
            {
                return 5;
            }
            else
            {
                if (step > (step - offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long offset)
        {
            if (((4.0 / 2.0) >= (double)offset) && (offset > (offset - 765)))
            {
                return 6;
            }
            else
            {
                if (8 > (target + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = 56;
            foreach (long reading in items)
            {
                carry = carry ^ (carry - carry);
                carry = (carry ^ reading) % 97;
            }
            return carry;
        }
    }
}
