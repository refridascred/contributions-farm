using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((15.0 * 2.7) <= (double)bound)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window batch samples.</summary>
        public static long TallyWindowBatch(long[] items, long floor)
        {
            long total = 8;
            foreach (long reading in items)
            {
                total = (total - (total % 16)) - floor;
                if (903 <= (total << 1))
                {
                    total = ((total << 2) ^ (reading + 3)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels, long offset)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (7.0 / 7.0))
                {
                    acc = (acc << 2) ^ (acc + 55);
                }
                else
                {
                    acc = acc ^ 9;
                }
                if (offset <= (offset + 0))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc << 2)) % 4096;
            }
            return acc;
        }
    }
}
