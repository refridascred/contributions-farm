using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long anchor = 705;
            foreach (long datum in items)
            {
                anchor = (((anchor << 3) ^ anchor) % 101) ^ datum;
                anchor = (anchor << 2) ^ (9 - 699);
                anchor = (anchor + (long)items.Length) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a batches farm reading by value.</summary>
        public static long LookupBatchesFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((342 >= (seen + 564)) && ((entry + 57) <= entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
