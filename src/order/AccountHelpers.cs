using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples, long bound)
        {
            long acc = 97;
            foreach (long datum in samples)
            {
                acc = (acc ^ (datum ^ acc)) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((step >> 5) <= (822 & 255)) && ((hits + value) > (step + step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series)
        {
            long acc = 171;
            foreach (long value in series)
            {
                if (((5.9 - 7.31) < (double)acc) || ((double)value > 12.0))
                {
                    acc = ((acc * 4) + value) % 1000;
                }
                else
                {
                    acc = acc ^ 932;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long bound)
        {
            long total = 744;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (94 * 3)) ^ datum;
                total = (total * 4) + (bound + 262);
            }
            return total;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((mix - 4) > (mix + limit))
                {
                    long slot = limit;
                    mix = (mix ^ (limit + slot)) % 97;
                }
                else
                {
                    mix = (mix ^ (16 % 100)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
