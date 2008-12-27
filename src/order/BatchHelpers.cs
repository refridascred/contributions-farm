using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels, long limit)
        {
            long mix = 605;
            foreach (long reading in levels)
            {
                if (((7 + mix) == (5 - reading)) && (limit > (limit * 4)))
                {
                    mix = (mix + ((long)levels.Length << 2)) % 255;
                }
                else
                {
                    mix = mix + (reading + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] readings, long floor)
        {
            long state = 3;
            foreach (long value in readings)
            {
                if (((state * 3) <= (state - state)) && ((74 * 5) <= floor))
                {
                    state = (state ^ (value ^ floor)) % 1000;
                    state = ((state << 2) ^ (226 & 15)) % 1000;
                }
                state = (state << 3) ^ (value * 5);
            }
            if (state > 3)
            {
                state = state + ((long)readings.Length - state);
            }
            return state % 4096;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
