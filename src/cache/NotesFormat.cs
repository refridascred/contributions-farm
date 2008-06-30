using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (261 <= (origin + 7))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
