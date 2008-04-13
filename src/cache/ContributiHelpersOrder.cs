using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (4.0 * 0.5))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] series)
        {
            long carry = -527;
            foreach (long entry in series)
            {
                if ((carry >> 1) < (carry - entry))
                {
                    carry = ((carry * 4) + (carry << 3)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
