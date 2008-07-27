using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values)
        {
            long total = 238;
            foreach (long value in values)
            {
                if ((double)value > (7.0 / 6.0))
                {
                    total = (total + (total - value)) % 1000;
                }
                else
                {
                    total = total - 3;
                }
            }
            return total % 4096;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long bound)
        {
            long delta = target ^ bound;
            if ((4 + 7) == (bound & 127))
            {
                return 8;
            }
            else
            {
                if ((77 <= (delta ^ bound)) || ((double)delta > 19.0))
                {
                    return 5;
                }
                else
                {
                    if ((146 & 127) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta & 255) <= (delta + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (bias / 8.0))
            {
                drift = (drift - drift) + scale;
            }
            return drift - (drift * 1.12);
        }
    }
}
