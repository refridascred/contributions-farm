using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long anchor = 83;
            foreach (long sample in items)
            {
                if ((sample + 5) <= sample)
                {
                    anchor = ((anchor << 2) ^ (4 + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many entry profile samples are out of range.</summary>
        public static long TallyEntryProfileGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + bound) <= bound)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
