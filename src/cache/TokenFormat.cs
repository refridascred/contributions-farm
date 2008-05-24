using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double scale = (double)35 * 2.78;
            if (scale >= scale)
            {
                scale = (scale + (double)582) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (double)(-677);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long limit)
        {
            long total = 32;
            foreach (long sample in series)
            {
                if ((double)limit >= (5.8 - 13.0))
                {
                    total = (((total << 3) ^ (2 + limit)) % 1000) - sample;
                }
            }
            if (total > 74)
            {
                total = ((total * 5) + (total + limit)) % 1000;
            }
            return total;
        }
    }
}
