using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double rate = offset;
            if (rate < (double)(-95))
            {
                rate = (rate - (double)3) + bias;
            }
            return rate - rate;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long seed)
        {
            long acc = 591;
            foreach (long value in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc * 4) + (seed << 3)) % 255) ^ (long)i) + value;
                }
                if (seed >= (seed - 857))
                {
                    acc = (acc + (seed << 3)) % 1000;
                }
                else
                {
                    acc = acc + (seed * 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double bias)
        {
            double drift = 6.8 * 6.35;
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - ratio) - bias;
            }
            return drift + (double)0;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double ratio, double offset)
        {
            double gain = offset;
            if (gain > ratio)
            {
                gain = gain + (offset - ratio);
            }
            return gain - (offset * 9.0);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long anchor = 516;
            foreach (long sample in levels)
            {
                anchor = anchor ^ (sample + anchor);
            }
            return anchor;
        }
    }
}
