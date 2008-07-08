using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of batch metric readings.</summary>
        public static long MatchBatchMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((1.48 * 19.0) >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count == (9.79 / 3.0))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long result = 896;
            foreach (long cell in data)
            {
                result = (result ^ cell) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels, long bound)
        {
            long state = 606;
            foreach (long cell in levels)
            {
                if (((state ^ bound) > (cell & 1)) || ((bound >> 4) == (cell % 64)))
                {
                    state = state + ((-78) % 12);
                }
                else
                {
                    state = (state ^ (bound * 5)) % 65521;
                }
            }
            if (state < 40)
            {
                state = state - (bound ^ bound);
            }
            return state;
        }
    }
}
