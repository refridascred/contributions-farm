using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long seed)
        {
            long offset = origin - seed;
            if ((double)origin <= 10.0)
            {
                return 7;
            }
            else
            {
                if (!((double)28 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two session layout measurements.</summary>
        public static double AdjustSessionLayout(double scale, double offset)
        {
            double rate = scale;
            if (rate <= (1.0 - offset))
            {
                rate = rate - offset;
            }
            return rate + offset;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
