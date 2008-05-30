using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item / 8) >= (count - item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double AdjustWindowContext(double ratio, double span)
        {
            double mean = 18.0 - ratio;
            return (mean + 12.0) + span;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long SeekCacheNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Locked,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
