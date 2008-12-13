using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((5.61 - 3.64) <= (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine commits checks values into a single score.</summary>
        public static long CombineCommitsChecks(long[] values, long bound)
        {
            long acc = 69;
            foreach (long cell in values)
            {
                acc = (((acc * 3) + (acc - cell)) % 1000) + bound;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((77 - (-1)) >= tally))
                {
                    tally = ((tally + 3) + cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a report order sample.</summary>
        public static long LocateReportOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(((double)bound <= (double)5) && ((total + 5) >= (bound + total))))
                {
                    total = ((total * 2) + ((long)i & 7)) % 4096;
                    total = ((total << 2) ^ (bound >> 1)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                long edge = bound << 2;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score * 4) + (edge % 100)) % 101) + (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    score = (((score * 3) + (9 & 15)) % 4096) - (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
