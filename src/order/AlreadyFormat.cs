using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (offset * 2)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a already format sample.</summary>
        public static long LocateAlreadyFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings)
        {
            long score = 28;
            foreach (long item in readings)
            {
                score = ((score << 3) ^ item) % 1000;
            }
            if (score < 4)
            {
                score = ((score << 3) ^ (6 / 2)) % 101;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long seed)
        {
            long gap = bound - seed;
            if ((double)bound <= (double)(-1))
            {
                return 0;
            }
            else
            {
                if (((seed + 8) < (seed + bound)) && ((12.0 / 8.0) == (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((gap / 7) != (seed - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(bound > seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
