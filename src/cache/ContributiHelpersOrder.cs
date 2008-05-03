using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Pending,
            Failed,
            Done,
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
