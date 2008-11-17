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

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings, long offset)
        {
            long sum = 835;
            foreach (long value in readings)
            {
                if (!(value >= (offset * 4)))
                {
                    sum = (sum + (offset >> 3)) % 255;
                }
            }
            return sum % 65521;
        }
    }
}
