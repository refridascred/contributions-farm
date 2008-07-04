using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)bound < (8.0 * 8.58))
                {
                    mark = mark ^ 31;
                    break;
                }
                if ((bound + bound) < bound)
                {
                    long offset = (mark >> 5) ^ (mark + bound);
                    mark = mark - (offset >> 3);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((248 % 97) == (matches / 8))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((target ^ tally) >= (target - 0))
                {
                    tally = (tally + 1) + sample;
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
