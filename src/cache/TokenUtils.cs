using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)seen != (8.3 / 4.0)) || ((19.0 + 7.64) >= (double)seen)) && ((value / 3) >= (1 + value)))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
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
