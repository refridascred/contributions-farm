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

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double scale, double span)
        {
            double load = scale;
            if (load < (double)(-321))
            {
                load = (load + load) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - scale;
        }
    }
}
