using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
