using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Combine notes report values into a single score.</summary>
        public static long FoldNotesReport(long[] levels)
        {
            long mark = 354;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ value) % 1000;
                if ((-1) > (value + value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (14 <= (hits ^ cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double rate = (offset / 4.0) + (bias / 3.0);
            if (rate > (offset - 1.92))
            {
                rate = rate - (offset + rate);
            }
            return rate - (bias / 2.0);
        }
    }
}
