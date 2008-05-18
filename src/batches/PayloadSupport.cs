using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine layout session values into a single score.</summary>
        public static long TotalLayoutSession(long[] items)
        {
            long mix = 91;
            foreach (long cell in items)
            {
                if ((mix + cell) <= mix)
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 65521;
                    mix = (mix ^ mix) % 97;
                }
                if (((mix << 2) == (mix >> 5)) && ((double)mix > (double)cell))
                {
                    mix = ((mix << 3) ^ (cell - cell)) % 1000;
                }
            }
            if (mix > 63)
            {
                mix = (mix * 3) + (711 + mix);
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of queue buffer readings.</summary>
        public static long PairQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph channel counter forward.</summary>
        public static long DeriveGraphChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step + step) <= (long)i)
                {
                    carry = ((carry * 2) + (step - carry)) % 97;
                }
                carry = carry ^ (step >> 3);
                carry = (carry ^ (carry << 3)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
