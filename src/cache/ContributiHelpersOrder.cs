using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 4) >= seen))
                {
                    seen = ((seen + 1) + datum) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes counter reading by value.</summary>
        public static long SeekNotesCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph layout samples.</summary>
        public static long TallyGraphLayout(long[] series, long target)
        {
            long score = 63;
            foreach (long reading in series)
            {
                if ((double)target < (8.24 / 3.0))
                {
                    score = ((score - (19 >> 1)) % 101) ^ reading;
                }
            }
            return score;
        }
    }
}
