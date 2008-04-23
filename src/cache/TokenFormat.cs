using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long AuditQueueContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((17 ^ value) == (tally + tally))
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

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
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
