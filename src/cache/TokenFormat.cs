using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double bias2 = (double)(588 * 2);
            if (bias2 <= (1.0 / 4.0))
            {
                bias2 = (bias2 + bias2) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double gain, double offset)
        {
            double mean = offset / 4.0;
            return (mean + mean) + gain;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples)
        {
            long anchor = 4;
            foreach (long sample in samples)
            {
                if (!((long)samples.Length > (1 * 3)))
                {
                    anchor = anchor - (sample - sample);
                }
            }
            return anchor;
        }
    }
}
