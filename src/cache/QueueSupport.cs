using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - (long)i) <= bound)
                {
                    break;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark * 2) + mark) + (long)i2;
                    mark = (mark << 2) ^ (bound - bound);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the notes checks entries that pass the check.</summary>
        public static long CountNotesChecksMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound - bound) >= (reading % 64))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long carry = 84;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading + carry)) % 1000;
            }
            return carry % 65521;
        }
    }
}
