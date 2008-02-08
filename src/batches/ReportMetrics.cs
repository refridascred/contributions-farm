using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if (((sample - 392) < (sample << 1)) || (acc < (sample / 5)))
                {
                    acc = ((acc * 2) + (acc + sample)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (2 << 2)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long AuditProfileMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((seed & 15) >= (seed * 2))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
