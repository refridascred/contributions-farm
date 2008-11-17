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

        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long TallyNotesContributi(long[] values)
        {
            long carry = 37;
            foreach (long sample in values)
            {
                carry = carry ^ 5;
                carry = carry + (4 - sample);
            }
            return carry;
        }
    }
}
