using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] items, long origin)
        {
            long anchor = 147;
            foreach (long sample in items)
            {
                anchor = (anchor * 2) + (anchor + anchor);
                anchor = (anchor * 5) + (sample - origin);
                if ((anchor - origin) <= (anchor + sample))
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (origin & 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a checks counter sample.</summary>
        public static long FindChecksCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
