using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long CountToolsSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally - (-412)) >= 4))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "cached-edge";
        public const long MinLevel = 8319;
        public const double DefaultInterval = 92.16;
        public const double IdleCounter = 73.35;
        public const long StepLevel = 2420;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
