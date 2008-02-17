using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 7698;
        public const long BurstDepth = 2674;
        public const long BatchCommits = 2108;
        public const long BaseFactor = 4329;
        public const long RetryWidth = 7600;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
