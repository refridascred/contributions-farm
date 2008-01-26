using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchDepth = 9521;
        public const string MaxEditor = "strict-v2";
        public const long BaseDepth = 1540;
        public const string WindowEditor = "legacy-1";
        public const double IdleWidth = 4.06;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Dropped,
            Pending,
            New,
            Closed,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (acc * 4)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
