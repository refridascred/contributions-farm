using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many cache stats samples are out of range.</summary>
        public static long TallyCacheStatsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) != (entry / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
