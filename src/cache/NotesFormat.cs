using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 9859;
        public const double DefaultEntry = 73.83;
        public const long BaseLevel = 8102;
        public const long HardInterval = 8121;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample >= (8.0 * 3.6)) || ((sample < (sample ^ sample)) && ((sample >> 1) <= (sample / 7))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
