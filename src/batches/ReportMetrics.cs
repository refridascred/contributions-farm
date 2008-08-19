using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long target, long limit)
        {
            long edge = target ^ limit;
            if (((double)target != (8.99 / 3.0)) || ((target & 7) <= (edge / 8)))
            {
                return 7;
            }
            else
            {
                if (limit < (edge / 4))
                {
                    return 0;
                }
                else
                {
                    if (((double)limit > (6.55 / 7.0)) || ((target * 5) < (target + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 << 2) > (edge >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 <= gain)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias / 3.0);
            }
            return bias2 - (double)441;
        }
    }
}
