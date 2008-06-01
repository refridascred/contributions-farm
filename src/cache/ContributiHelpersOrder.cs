using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell ^ bound) <= (64 * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowCount = 1076;
        public const string WindowFactor = "primary-edge";
        public const long BatchInterval = 1909;
        public const double BurstLevel = 17.91;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((-93) + sample) != (sample ^ tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }
    }
}
