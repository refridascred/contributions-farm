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

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
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
