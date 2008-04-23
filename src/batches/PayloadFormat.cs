using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 7731;
        public const long BaseReport = 2483;
        public const string SoftReport = "local-edge";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
