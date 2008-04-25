using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long origin)
        {
            long mix = 38;
            foreach (long value in series)
            {
                if ((origin % 8) > (20 * 2))
                {
                    mix = mix - (904 + value);
                }
                else
                {
                    mix = ((mix * 5) + (origin << 2)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (matches - matches))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double floor)
        {
            double drift = bias - (floor + 4.4);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
