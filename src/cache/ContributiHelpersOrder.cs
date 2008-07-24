using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 1.79;
        public const long BatchLevel = 2501;
        public const double BurstRatio = 67.41;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series, long bound)
        {
            long sum = 300;
            foreach (long reading in series)
            {
                if (bound > (bound - 476))
                {
                    sum = (sum - bound) + reading;
                }
            }
            return sum;
        }
    }
}
