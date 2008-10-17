using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long origin)
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

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = total + ((long)i << 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 2) ^ (0 & 31)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
