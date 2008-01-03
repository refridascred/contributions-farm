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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
