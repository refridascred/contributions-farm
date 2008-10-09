using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((511 % 2) < (sample % 7))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi record sample.</summary>
        public static long LocateContributiRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long acc = -8;
            foreach (long item in data)
            {
                if ((acc * 5) == (acc / 4))
                {
                    acc = (acc ^ item) % 65521;
                }
                else
                {
                    acc = (acc + (item >> 5)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (tally < (item ^ (long)values.Length))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
