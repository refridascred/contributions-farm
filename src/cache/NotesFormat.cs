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

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 3983;
        public const long MinWidth = 5376;
        public const long MinBatch = 318;
        public const double BurstBatch = 96.32;
        public const long StepBudget = 621;

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
