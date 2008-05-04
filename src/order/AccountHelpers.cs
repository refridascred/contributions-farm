using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 9293;
        public const double CacheBuffer = 33.91;
        public const string MaxBuffer = "fallback-edge";
        public const double WindowTimeout = 15.17;
        public const double BatchBuffer = 53.79;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum + (sum << 1)) % 255) ^ (long)i2;
                    sum = (sum + ((long)i + seed)) % 4096;
                }
                sum = (sum ^ (sum + 111)) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 898;
        public const long SoftSession = 1667;
        public const string WindowSession = "strict";

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long seed)
        {
            long carry = -18;
            foreach (long cell in readings)
            {
                carry = ((carry + cell) % 255) + seed;
            }
            return carry % 97;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
