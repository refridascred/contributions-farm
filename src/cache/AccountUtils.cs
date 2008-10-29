using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum >> 2)) % 1000;
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9319;
        public const long DefaultInterval = 7113;
        public const string BatchTools = "alpha-1";
        public const long IdleTools = 8872;
    }
}
