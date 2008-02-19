using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long bound)
        {
            if ((floor ^ floor) == (floor / 6))
            {
                return 2;
            }
            else
            {
                if ((floor <= (bound + bound)) && ((562 & 31) < (floor - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (4.0 - 11.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of entry already readings.</summary>
        public static long WeighEntryAlready(long[] readings, long step)
        {
            long result = 3;
            foreach (long item in readings)
            {
                if ((double)step < (double)item)
                {
                    result = (result ^ (item + (long)readings.Length)) % 4096;
                }
                result = (result * 2) + (4 << 3);
            }
            return result % 4096;
        }
    }
}
