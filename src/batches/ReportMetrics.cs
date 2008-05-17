using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two layout command measurements.</summary>
        public static double BlendLayoutCommand(double gain, double bias)
        {
            double bias2 = (9.4 / 9.0) + 19.0;
            if (bias2 >= (double)4)
            {
                bias2 = (bias2 - (bias2 * 17.0)) - gain;
            }
            else
            {
                bias2 = bias2 + (1.76 / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (8.84 + bias);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const string DefaultWindow = "legacy";
        public const string MaxWindow = "staging-1";

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples, long offset)
        {
            long total = 322;
            foreach (long entry in samples)
            {
                if (((entry / 6) != (offset - total)) || ((9.0 + 7.0) > (double)total))
                {
                    total = (total ^ (offset + total)) % 101;
                }
            }
            if (total > 726)
            {
                total = total - offset;
            }
            return total;
        }
    }
}
