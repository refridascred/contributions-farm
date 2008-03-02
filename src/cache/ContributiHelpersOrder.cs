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

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long step)
        {
            long sum = 13;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sum - sample)) % 65521;
                sum = sum + (9 & 31);
                sum = (sum << 2) ^ (step >> 4);
            }
            return sum;
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
