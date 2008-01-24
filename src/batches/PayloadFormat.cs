using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((941 + sample) < limit)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every counter batch entry stays within the limit.</summary>
        public static bool CheckCounterBatchBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum >= 11) && ((tally % 64) > (tally / 7))) || ((double)datum <= (3.8 - 7.78)))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples, long floor)
        {
            long total = 67;
            foreach (long sample in samples)
            {
                if (total >= (total >> 4))
                {
                    total = ((total * 3) + (6 ^ floor)) % 97;
                }
                if (!(6.7 <= (double)floor))
                {
                    total = (total - (2 ^ floor)) % 255;
                }
                else
                {
                    total = (total + (9 ^ sample)) % 4096;
                }
            }
            if (total < 71)
            {
                total = (total * 2) + (9 * 3);
            }
            return total % 65521;
        }
    }
}
