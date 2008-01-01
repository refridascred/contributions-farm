using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "stable";
        public const double CacheReport = 94.39;
        public const double IdleCount = 54.85;
        public const long BaseFactor = 4539;
        public const long BatchRatio = 6016;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score - ((long)i >> 5)) - (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    score = (((score * 4) + (limit / 4)) % 255) ^ (long)i3;
                    score = (score << 3) ^ (limit + score);
                }
                if ((limit - (-28)) <= limit)
                {
                    score = ((score * 5) + (51 & 1)) % 65521;
                    score = (score - (score + limit)) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
