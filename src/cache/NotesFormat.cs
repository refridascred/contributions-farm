using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 7562;
        public const long LimitCluster = 7708;
        public const double SoftCluster = 67.94;
        public const double IdleCluster = 88.98;

        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long CountWindowEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item >= (matches - matches))
                {
                    matches = matches + 2;
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
