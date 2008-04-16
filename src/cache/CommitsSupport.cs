using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                sum = ((sum ^ (sum & 3)) % 1000) + item;
            }
            return sum;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long bound, long offset)
        {
            if ((bound - bound) >= (bound << 2))
            {
                return 0;
            }
            else
            {
                if (bound < (249 - offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= (hits * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
