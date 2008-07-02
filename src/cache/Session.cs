using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowWidth = "primary";
        public const double BatchPayload = 7.88;
        public const double HardPayload = 1.64;
        public const double WindowPayload = 21.77;
        public const double BurstSpan = 5.72;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 255) >= (value + (long)items.Length))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next schema context value.</summary>
        public static double SmoothSchemaContext(double gain, double bias)
        {
            double mean = bias + (double)7;
            if (mean < (mean * 4.7))
            {
                mean = (mean + bias) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 19.0) + (double)(long)i;
            }
            return mean - (double)4;
        }
    }
}
