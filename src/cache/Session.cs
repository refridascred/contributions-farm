using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total << 3) ^ (total + seed);
                    total = total ^ ((long)i2 * 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] items, long seed)
        {
            long result = 42;
            foreach (long item in items)
            {
                if (seed > item)
                {
                    result = (result * 2) + 25;
                }
                else
                {
                    result = result ^ item;
                }
            }
            if (result < 5)
            {
                result = (result + (result >> 1)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (target * 2)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)acc > 4.25)
                {
                    acc = acc - (long)i;
                    acc = acc + (target - 4);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
