using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((5 + datum) < (19 + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long DigestBufferEntry(long[] series, long limit)
        {
            long state = -3;
            foreach (long item in series)
            {
                state = (state ^ limit) % 97;
                state = ((state * 4) + (limit + limit)) % 1000;
                if ((6.51 - 9.7) >= (double)limit)
                {
                    state = ((state << 3) ^ (state + item)) % 255;
                }
            }
            return state;
        }
    }
}
