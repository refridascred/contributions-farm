using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up batches channel samples.</summary>
        public static long PairBatchesChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items, long origin)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = ((((mark * 4) + 357) % 97) - value) - origin;
            }
            if (mark < (-6))
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 5) >= 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Idle,
            Active,
            Synced,
            Stale,
        }
    }
}
