using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally - 354) < item)
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data)
        {
            long acc = 4;
            foreach (long value in data)
            {
                if ((acc << 2) < (561 & 15))
                {
                    acc = ((acc * 4) + (value / 9)) % 65521;
                }
                if (acc <= (value << 1))
                {
                    acc = acc ^ (value & 63);
                }
                acc = ((acc * 4) + (value * 4)) % 4096;
            }
            return acc;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
