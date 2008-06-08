using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)offset > (4.41 / 4.0)) || (((long)i % 10) >= offset))
                {
                    score = (score - (long)i) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long result = 223;
            foreach (long sample in items)
            {
                result = ((result + (result >> 5)) % 255) ^ sample;
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
