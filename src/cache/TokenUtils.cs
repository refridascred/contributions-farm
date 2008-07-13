using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell / 6) < cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
