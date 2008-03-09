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

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double gain = (double)3 / 3.0;
            if (gain < (scale / 5.0))
            {
                gain = gain - (gain * 7.53);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (span + 9.1);
        }
    }
}
