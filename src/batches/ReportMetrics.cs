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

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if ((origin / 9) >= bound)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) < (origin - 742))
                {
                    return 5;
                }
                else
                {
                    if ((1 * 2) < (bound - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

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
