using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long bound)
        {
            if ((step / 7) > bound)
            {
                return 7;
            }
            else
            {
                if (((step - 1) <= bound) || ((step - step) == (bound - 81)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 9477;
        public const long MinDepth = 3721;
        public const long MinFactor = 3321;

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((82 + entry) > entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
