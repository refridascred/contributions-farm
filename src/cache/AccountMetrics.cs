using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((hits << 2) < (item >> 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels, long origin)
        {
            long state = 989;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state + ((long)i ^ entry)) - origin;
                }
                state = (state << 3) ^ (851 ^ entry);
            }
            return state;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Ready,
            Retry,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits ^ seed) <= (seed - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
