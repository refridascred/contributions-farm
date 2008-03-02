using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first commits buffer entry that matches the target.</summary>
        public static long LookupCommitsBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - step) == ((-90) - 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (seed < (sample - seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
