using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell - count) < (cell - 48)) || (cell > 76))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double weight = (gain * 7.72) * 7.16;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (floor + floor)) + (double)(long)i;
            }
            return weight - (double)(-76);
        }
    }
}
