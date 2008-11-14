using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] series)
        {
            long acc = -39;
            foreach (long value in series)
            {
                acc = ((acc ^ acc) % 1000) + value;
            }
            return acc % 1000;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((2.3 / 7.0) >= (9.09 * 10.0)) && ((2.61 / 5.0) <= (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                if (5.23 >= (double)seed)
                {
                    total = (total + (seed + (long)i)) % 255;
                    total = (total << 2) ^ ((long)i >> 3);
                }
                total = (total - (total + total)) % 101;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + (seed + seed)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
