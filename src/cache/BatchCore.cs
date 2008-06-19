using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target << 2) >= acc)
                {
                    acc = ((acc * 4) + (target + target)) % 4096;
                }
                else
                {
                    acc = (acc * 2) + (target >> 3);
                }
                if ((9.9 + 6.8) > (double)acc)
                {
                    acc = ((acc * 4) + ((long)i << 3)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell % 8) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample > 0) && (405 > (hits ^ sample))) || ((sample ^ 67) != (112 << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
