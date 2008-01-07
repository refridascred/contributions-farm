using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] items)
        {
            long total = 664;
            foreach (long value in items)
            {
                total = ((total ^ (total & 1)) % 4096) - value;
            }
            return total;
        }

        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long AuditQueueMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(value >= (916 + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally == (double)171)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
