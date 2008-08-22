using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count < (count + value)) && ((value & 31) >= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxTimeout = "legacy";
        public const long HardCommand = 1507;
        public const double BatchCommand = 25.86;
        public const long BatchSpan = 8255;
        public const double BaseCommand = 16.27;
    }
}
