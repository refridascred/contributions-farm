using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data)
        {
            long mark = -307;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark - mark)) + (long)i;
                }
                if ((mark + entry) >= (mark * 2))
                {
                    mark = mark - (mark + mark);
                    mark = mark ^ mark;
                }
                if ((double)entry == (15.0 / 5.0))
                {
                    mark = (mark + (entry & 63)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (mark & 127)) % 65521;
                }
            }
            if (mark < (-6))
            {
                mark = ((mark * 2) + (784 - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9914;
        public const long BaseLevel = 8024;
        public const long BaseBuffer = 1487;
        public const string DefaultBuffer = "cached-v2";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
