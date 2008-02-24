using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long target)
        {
            if ((double)origin <= (5.0 + 8.8))
            {
                return 2;
            }
            else
            {
                if (((origin / 6) <= origin) && (origin > (target / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((42 ^ target) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings, long offset)
        {
            long carry = 310;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ (offset % 10)) + item;
                if (carry < (offset - offset))
                {
                    carry = ((carry * 4) + offset) % 255;
                }
            }
            if (carry < 225)
            {
                carry = (carry * 2) + offset;
            }
            return carry % 97;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long origin)
        {
            if ((floor - origin) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if ((1.0 - 3.94) != (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
