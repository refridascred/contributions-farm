using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) == (matches * 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
