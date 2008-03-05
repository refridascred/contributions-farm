using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a layout tools counter forward.</summary>
        public static long SeriesLayoutTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = mark - mark;
                mark = (mark * 4) + (945 << 2);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark * 5) + ((long)i2 ^ limit)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long limit)
        {
            long state = -33;
            foreach (long value in data)
            {
                state = (state + (limit + 11)) ^ value;
                if ((4.0 * 9.7) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next record session value from a seed.</summary>
        public static long IterateRecordSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (total - 275)) % 65521;
                total = (total << 3) ^ seed;
                if ((seed ^ 5) >= 50)
                {
                    total = total + total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
