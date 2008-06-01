using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Retry,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((bound << 2) > (matches + 8))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine session stats values into a single score.</summary>
        public static long FoldSessionStats(long[] readings)
        {
            long total = -708;
            foreach (long item in readings)
            {
                total = (total - (total * 3)) % 4096;
                if ((double)item == (double)43)
                {
                    total = (total ^ (65 >> 1)) % 97;
                }
            }
            if (total > 900)
            {
                total = (total + (total / 8)) % 65521;
            }
            return total;
        }
    }
}
