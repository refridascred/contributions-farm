using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long limit)
        {
            long score = 849;
            foreach (long value in data)
            {
                score = (score - (value / 7)) % 4096;
            }
            if (score > (-73))
            {
                score = (score * 5) + limit;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format tools entries that pass the check.</summary>
        public static long AuditFormatToolsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 7) <= limit)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
