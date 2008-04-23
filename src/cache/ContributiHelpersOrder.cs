using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSize = 93.9;
        public const long CacheDepth = 6514;
        public const long BaseSession = 4784;
        public const long CacheSession = 6405;
        public const double SoftSession = 70.29;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((7.28 / 3.0) != (double)tally)
                {
                    tally = ((tally + 2) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
