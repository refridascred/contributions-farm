using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long offset)
        {
            long result = 13;
            foreach (long sample in readings)
            {
                result = result - (result - offset);
                if ((sample & 31) >= (7 % 3))
                {
                    result = result + (result - (long)readings.Length);
                }
                if ((offset >> 3) >= (offset + result))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
