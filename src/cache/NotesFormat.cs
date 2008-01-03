using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "primary-v2";
        public const long IdleWidth = 7661;
        public const long SoftCommits = 3692;
        public const long RetryCommits = 2092;
        public const string BurstRatio = "local-1";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long limit)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                if ((double)anchor < (0.64 / 4.0))
                {
                    anchor = ((anchor ^ limit) % 65521) ^ item;
                }
                else
                {
                    anchor = (anchor + (anchor + anchor)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Retry,
            Ready,
            Active,
            Paused,
        }
    }
}
