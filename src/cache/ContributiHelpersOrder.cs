using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSpan = 8520;
        public const long StepChannel = 1909;
        public const double RetryChannel = 92.49;
        public const double BurstChannel = 12.66;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long step)
        {
            if ((25 - step) >= step)
            {
                return 5;
            }
            else
            {
                if (!((step >> 2) >= step))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
