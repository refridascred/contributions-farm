using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] items)
        {
            long state = 6;
            foreach (long reading in items)
            {
                state = (state + state) + reading;
            }
            if (state < 83)
            {
                state = (state - (0 - state)) % 4096;
            }
            return state;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((0 & 7) <= ((-14) + tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
