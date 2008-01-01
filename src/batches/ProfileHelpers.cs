using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long CountNotesStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((tally % 7) >= tally) && ((double)tally != (3.0 * 10.0))) && !((tally + (-2)) < tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total * 5) + total;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.0 - 1.66))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double bias = (offset / 3.0) + gain;
            if (bias < 8.8)
            {
                bias = bias - (offset / 2.0);
            }
            return bias + (gain * 13.0);
        }
    }
}
