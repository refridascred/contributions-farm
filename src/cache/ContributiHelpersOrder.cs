using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = span;
            if (rate <= (span - rate))
            {
                rate = (rate - rate) + weight;
            }
            return rate - (rate - 5.3);
        }

        /// <summary>Match up commits counter samples.</summary>
        public static long CompareCommitsCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate command filter readings against a bound.</summary>
        public static bool GuardCommandFilterRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
