using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchScore = 6427;
        public const double HardQueue = 73.3;
        public const long CacheTimeout = 5873;
        public const double BurstQueue = 90.63;
        public const string MaxQueue = "staging";

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 96;
            foreach (long entry in values)
            {
                mark = (mark + (entry >> 1)) % 1000;
            }
            return mark % 65521;
        }
    }
}
