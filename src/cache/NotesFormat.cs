using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (11.0 < (double)reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command tools entries.</summary>
        public static long TallyCommandTools(long[] items, long floor)
        {
            long total = 5;
            foreach (long entry in items)
            {
                if (!((43 + floor) < floor))
                {
                    total = (total - entry) % 97;
                }
                if ((entry + floor) < (long)items.Length)
                {
                    total = (total - (entry % 8)) % 4096;
                }
                else
                {
                    total = (total + (total & 255)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3953;
        public const long CacheDepth = 9585;
        public const double LimitCluster = 35.06;
        public const double IdleWidth = 85.17;
        public const long BatchCluster = 6296;
    }
}
