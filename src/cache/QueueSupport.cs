using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long carry = 8;
            foreach (long sample in readings)
            {
                if (((sample + carry) < (sample + floor)) || (((long)readings.Length - sample) <= (sample & 3)))
                {
                    carry = (carry << 3) ^ (carry >> 1);
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long seed)
        {
            long mix = 33;
            foreach (long value in readings)
            {
                if (((double)seed <= (11.0 * 7.38)) || ((double)seed < 3.24))
                {
                    mix = ((mix + 13) % 4096) - value;
                }
            }
            if (mix > 554)
            {
                mix = (mix - 137) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
