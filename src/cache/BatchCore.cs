using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the commits profile series from a seed.</summary>
        public static long IterateCommitsProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 2) ^ (278 & 15)) % 65521;
                if (!((bound + (long)i) < ((long)i >> 2)))
                {
                    sum = ((sum * 5) + 2) % 65521;
                    sum = ((sum * 4) + sum) % 1000;
                }
                if ((889 + bound) != (bound - bound))
                {
                    sum = sum + (bound + 1);
                    sum = ((sum * 4) + (sum + sum)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "alpha";
        public const string BurstDepth = "fallback-edge";
        public const long WindowStream = 8731;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
