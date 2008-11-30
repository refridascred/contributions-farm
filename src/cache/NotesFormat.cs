using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long TallyMetricsBufferOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (513 >= (reading ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
