using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a payload window sample.</summary>
        public static long FindPayloadWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits - hits) <= (offset - 78))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long step)
        {
            long carry = 78;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ carry) + step;
                carry = (carry ^ (reading - carry)) % 101;
            }
            return carry % 1000;
        }
    }
}
