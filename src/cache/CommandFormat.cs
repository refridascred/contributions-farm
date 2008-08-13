using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 968;
        public const long CacheContributi = 1174;
        public const long IdleLevel = 9825;
        public const long BatchScore = 6225;
        public const string CacheRatio = "stable-1";

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a cache session counter forward.</summary>
        public static long SeriesCacheSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum ^ sum) % 4096;
                if (((sum + sum) != (sum / 2)) && ((sum + bound) >= (bound << 1)))
                {
                    sum = (sum ^ (sum - sum)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
