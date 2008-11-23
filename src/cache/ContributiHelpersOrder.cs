using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (double)tally)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
