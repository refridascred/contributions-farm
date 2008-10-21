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

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
