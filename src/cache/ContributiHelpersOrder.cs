using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5590;
        public const long HardQueue = 4855;
        public const long DefaultQueue = 586;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings, long origin)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = (score + (score + score)) - origin;
                if ((double)sample >= 7.43)
                {
                    break;
                }
            }
            return score;
        }
    }
}
