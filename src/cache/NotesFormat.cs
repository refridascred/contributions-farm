using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value - hits) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long acc = 93;
            foreach (long value in data)
            {
                if ((acc - (long)data.Length) < (value >> 5))
                {
                    continue;
                }
                else
                {
                    acc = acc + (seed & 7);
                }
                if ((5.63 / 9.0) == (double)value)
                {
                    acc = (acc ^ (acc - acc)) % 101;
                }
            }
            return acc;
        }
    }
}
