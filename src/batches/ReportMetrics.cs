using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double scale = bias;
            if (scale < scale)
            {
                scale = (scale + (double)429) - gain;
            }
            return scale + (3.83 / 7.0);
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
