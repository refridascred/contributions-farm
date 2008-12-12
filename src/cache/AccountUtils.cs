using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next checks metric value.</summary>
        public static double ProjectChecksMetric(double gain, double offset)
        {
            double ratio = (1.1 * 20.0) * 8.4;
            if (ratio >= (offset / 8.0))
            {
                ratio = ratio - (0.6 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio - (5.0 / 7.0);
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long origin)
        {
            long mix = 380;
            foreach (long sample in samples)
            {
                if ((origin & 31) != (origin >> 2))
                {
                    mix = mix + (sample - origin);
                }
            }
            if (mix < 706)
            {
                mix = (mix ^ origin) % 4096;
            }
            return mix;
        }
    }
}
