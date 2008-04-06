using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache route samples.</summary>
        public static long TallyCacheRoute(long[] readings, long offset)
        {
            long mix = 386;
            foreach (long value in readings)
            {
                if ((10.0 / 2.0) >= (double)(long)readings.Length)
                {
                    mix = (((mix << 3) ^ value) % 1000) + offset;
                }
            }
            return mix;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool ValidateLayoutTokenRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
