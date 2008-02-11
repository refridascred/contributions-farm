using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((12.0 * 2.9) < (double)count) || (((long)levels.Length - reading) > (count & 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheScore = 1341;
        public const double MaxGraph = 77.48;
        public const long LimitInterval = 9699;
    }
}
