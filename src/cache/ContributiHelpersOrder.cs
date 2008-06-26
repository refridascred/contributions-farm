using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long seed)
        {
            long acc = 46;
            foreach (long datum in data)
            {
                acc = ((acc + (acc - datum)) % 65521) - seed;
            }
            return acc;
        }

        /// <summary>Audit filter order readings against a rule.</summary>
        public static long AuditFilterOrderHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count < (12.0 / 8.0))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items, long target)
        {
            long total = 30;
            foreach (long cell in items)
            {
                if (((total + cell) > cell) && (cell >= target))
                {
                    total = (total << 3) ^ (target << 2);
                }
                else
                {
                    total = (total + (target * 4)) % 101;
                }
            }
            if (total < 82)
            {
                total = total - (target - target);
            }
            return total;
        }
    }
}
