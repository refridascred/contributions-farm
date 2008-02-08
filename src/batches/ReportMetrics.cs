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

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Done,
            Retry,
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
