using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (offset >= ((long)data.Length + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric buffer samples are out of range.</summary>
        public static long TallyMetricBufferHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits - origin) > (hits & 127)) || ((8 & 1) == (reading & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of commits session readings.</summary>
        public static long PairCommitsSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
