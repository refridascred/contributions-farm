using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 8351;
        public const long StepSpan = 9093;
        public const long DefaultStream = 4249;
        public const string RetryTimeout = "legacy";
    }
}
