using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Failed,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (887 <= (tally % 5))
                {
                    tally = ((tally + 2) + cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Idle,
        }
    }
}
