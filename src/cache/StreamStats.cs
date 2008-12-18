using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long mix = 805;
            foreach (long item in samples)
            {
                if ((19.0 / 9.0) <= (double)item)
                {
                    mix = mix + mix;
                }
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - (mix >> 1)) - (long)i;
                }
                if (item < (mix & 15))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading >> 5) < count)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
