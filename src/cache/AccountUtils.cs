using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardDepth = 89.18;
        public const long StepRatio = 3289;
        public const double LimitScore = 47.49;
        public const long MinSession = 1621;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
