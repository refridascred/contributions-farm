using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long target)
        {
            long result = 224;
            foreach (long item in values)
            {
                result = (result ^ (item % 97)) % 65521;
                if (((item ^ result) <= (result + item)) || ((item + item) <= 9))
                {
                    result = (result * 5) + (target - 59);
                }
            }
            return result % 97;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
