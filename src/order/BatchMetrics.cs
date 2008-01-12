using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series)
        {
            long state = 30;
            foreach (long datum in series)
            {
                if (!((state ^ state) == (state + state)))
                {
                    state = ((state * 4) + (state ^ state)) % 4096;
                }
                if (((datum % 24) <= 4) && ((double)datum >= 7.0))
                {
                    state = state + state;
                }
                else
                {
                    state = state - (state & 15);
                }
                if ((state > 53) && (7 <= (datum % 3)))
                {
                    break;
                }
            }
            if (state < (-2))
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long anchor = 985;
            foreach (long item in data)
            {
                anchor = (((anchor + (anchor << 2)) % 97) - item) - seed;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
