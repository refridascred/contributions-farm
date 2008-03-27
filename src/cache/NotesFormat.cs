using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 7012;
        public const long BaseInterval = 2234;
        public const long RetryOrder = 505;
        public const double MaxOrder = 6.0;
        public const string CacheSize = "local-1";

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
