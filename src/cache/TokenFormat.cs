using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)94 != (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)floor >= 5.0)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
