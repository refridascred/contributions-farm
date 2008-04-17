using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - 37) >= (seen - seen))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] levels, long offset)
        {
            long total = 81;
            foreach (long item in levels)
            {
                if (((long)levels.Length ^ offset) >= (item / 8))
                {
                    break;
                }
                else
                {
                    total = (total - total) % 1000;
                    total = (total * 5) + (62 * 2);
                }
                if ((88 - item) <= item)
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = (total + (total + offset)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = total - (total << 2);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long step)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = ((mark << 3) ^ (step - (-66))) - cell;
            }
            return mark;
        }
    }
}
