using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double span)
        {
            double mean = (scale / 3.0) * 16.0;
            if (mean < (span * 1.3))
            {
                mean = mean - (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.9 - scale)) + (double)(long)i;
            }
            return mean - (mean + 0.92);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] samples)
        {
            long sum = 949;
            foreach (long item in samples)
            {
                sum = ((sum * 4) + (item % 8)) % 1000;
                if ((sum + sum) < (sum & 31))
                {
                    sum = sum ^ (sum ^ item);
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
