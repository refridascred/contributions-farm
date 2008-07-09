using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] series)
        {
            long carry = 180;
            foreach (long value in series)
            {
                carry = (carry + (5 + 7)) ^ value;
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target ^ target) == (long)data.Length)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token channel value from a seed.</summary>
        public static long IterateTokenChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor <= (total + total)) && ((double)(long)i > 2.6))
                {
                    total = (total * 5) + (floor & 255);
                    total = total + (floor << 1);
                }
                total = (total * 4) + (long)i;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
