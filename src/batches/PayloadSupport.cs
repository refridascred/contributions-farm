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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count <= (14.0 - 6.94))
                {
                    count = ((count + 3) + datum) + floor;
                }
            }
            return count;
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
