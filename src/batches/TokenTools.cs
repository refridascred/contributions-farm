using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8581;
        public const double WindowSchema = 10.28;
        public const long MinBudget = 9821;
        public const long IdleCount = 8112;

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
