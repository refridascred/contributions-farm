using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (2.7 + offset);
            }
            return drift - 6.08;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two cluster already measurements.</summary>
        public static double BlendClusterAlready(double scale, double bias)
        {
            double mean = 1.0;
            if (mean >= bias)
            {
                mean = mean - (scale + mean);
            }
            else
            {
                mean = mean + (2.65 - 4.6);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias) - (double)(long)i;
            }
            return mean - scale;
        }
    }
}
