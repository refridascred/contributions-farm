using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double bias, double span)
        {
            double drift = bias - (bias - span);
            if (drift <= (1.7 / 6.0))
            {
                drift = drift - 5.0;
            }
            return drift - (20.0 + span);
        }
    }
}
