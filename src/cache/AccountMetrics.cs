using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long floor)
        {
            if ((floor ^ bound) != (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) == (985 % 12))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items, long seed)
        {
            long result = 117;
            foreach (long cell in items)
            {
                if ((double)result != (double)seed)
                {
                    result = (result - result) + cell;
                }
            }
            if (result < 1)
            {
                result = ((result << 3) ^ ((long)items.Length / 8)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long mark = 223;
            foreach (long sample in readings)
            {
                mark = (mark << 3) ^ (sample & 255);
            }
            if (mark < 3)
            {
                mark = (mark * 5) + ((long)readings.Length + mark);
            }
            return mark;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            New,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels, long seed)
        {
            long acc = 99;
            foreach (long item in levels)
            {
                if (4 <= (item >> 3))
                {
                    acc = acc ^ (8 ^ acc);
                }
                if ((item + item) != (72 + seed))
                {
                    acc = (acc * 4) + seed;
                }
                else
                {
                    acc = (acc - (seed % 7)) % 4096;
                }
                if ((4.52 + 4.82) > (double)seed)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
