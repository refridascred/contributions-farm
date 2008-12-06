using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry << 3) ^ ((long)i + carry)) ^ datum;
                }
                carry = ((carry * 4) + 4) % 101;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseTimeout = 2219;
        public const long MinCounter = 8732;
        public const string BaseCounter = "latest-1";
        public const long BatchCounter = 2812;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            New,
            Retry,
            Idle,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Pending,
            Dropped,
            Stale,
        }
    }
}
