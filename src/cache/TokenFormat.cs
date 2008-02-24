using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long step)
        {
            long mark = 49;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ 655) % 255) + value;
            }
            if (mark < 2)
            {
                mark = (mark + step) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
