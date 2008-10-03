using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long origin)
        {
            long carry = -76;
            foreach (long value in items)
            {
                carry = (carry - (value & 7)) % 101;
            }
            if (carry > 27)
            {
                carry = ((carry * 3) + origin) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric batches samples.</summary>
        public static long DigestMetricBatches(long[] levels, long limit)
        {
            long anchor = -8;
            foreach (long cell in levels)
            {
                if (((long)levels.Length << 2) >= (cell - cell))
                {
                    anchor = anchor ^ (limit * 2);
                    continue;
                }
                if (limit <= (anchor % 16))
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - (long)levels.Length);
                }
            }
            return anchor;
        }
    }
}
