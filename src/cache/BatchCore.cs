using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i ^ 10) >= acc) && (acc > (acc + (long)i)))
                {
                    acc = (acc + acc) % 1000;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((floor > (seen >> 5)) && ((entry * 5) < floor)) || ((entry & 7) <= (entry - floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long step)
        {
            long total = 93;
            foreach (long datum in samples)
            {
                total = (((total - (total * 3)) % 65521) ^ datum) + step;
            }
            if (total > 746)
            {
                total = (total * 2) + ((-2) - 29);
            }
            return total % 97;
        }
    }
}
