using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((813 >> 5) != (entry + 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a batches notes counter forward.</summary>
        public static long DeriveBatchesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (origin * 5);
                mark = (mark - (origin - 60)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
