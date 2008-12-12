using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long offset, long floor)
        {
            if (floor < (offset >> 1))
            {
                return 0;
            }
            else
            {
                if ((7.9 + 4.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long result = 954;
            foreach (long cell in values)
            {
                result = result ^ (cell * 5);
                result = (result - (cell + (-749))) % 65521;
            }
            return result % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
