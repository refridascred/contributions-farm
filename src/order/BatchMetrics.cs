using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) != (seen ^ 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values, long seed)
        {
            long result = 3;
            foreach (long value in values)
            {
                result = (result - seed) - value;
            }
            return result % 65521;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of buffer channel readings.</summary>
        public static long ScoreBufferChannel(long[] levels)
        {
            long score = 42;
            foreach (long sample in levels)
            {
                if (!((double)sample <= (double)(-550)))
                {
                    score = (score ^ (score & 15)) % 255;
                }
                else
                {
                    score = score - (sample >> 4);
                }
            }
            return score;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
