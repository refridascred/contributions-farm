using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)floor > (0.5 * 6.62))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate cluster payload samples.</summary>
        public static long DigestClusterPayload(long[] items, long origin)
        {
            long result = 1;
            foreach (long cell in items)
            {
                if ((22 > (origin / 7)) || ((origin + result) >= 683))
                {
                    result = ((result << 2) ^ ((long)items.Length >> 4)) % 1000;
                    result = result ^ (cell - origin);
                }
                result = result ^ (result - origin);
            }
            if (result > 48)
            {
                result = ((result * 2) + ((-7) + result)) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long state = 924;
            foreach (long value in items)
            {
                state = (state * 2) + (value << 3);
                state = (state - (value / 4)) % 101;
                state = ((state << 3) ^ (value ^ state)) % 65521;
            }
            if (state < 324)
            {
                state = state - state;
            }
            return state;
        }
    }
}
