using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 1868;
        public const long LimitSupport = 6182;
        public const long HardScore = 7713;
        public const string MinTimeout = "strict";

        /// <summary>Look up the position of a session tools sample.</summary>
        public static long SeekSessionToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}
