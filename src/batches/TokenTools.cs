using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double bias = (double)(-560) * 5.3;
            if (bias < bias)
            {
                bias = (bias - (bias - bias)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (rate - 1.52)) - (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Audit account format readings against a rule.</summary>
        public static long TallyAccountFormatHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((floor + hits) != (hits << 3))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
