using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double scale = (double)24 - bias;
            if (scale < (0.5 - scale))
            {
                scale = (scale + (double)3) + rate;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (scale * 19.0);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - value) == (seen + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "strict";
        public const long BurstSchema = 3457;
        public const long MaxSchema = 899;
        public const long SoftWidth = 2881;
        public const double BatchCount = 78.11;
    }
}
