using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseCount = 45.35;
        public const string BatchLevel = "open-edge";
        public const long LimitProfile = 4612;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Pending,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 5.79;
        public const string BaseContext = "open";
        public const string DefaultSize = "staging-v2";

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
