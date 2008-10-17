using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Idle,
            New,
            Pending,
            Ready,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long step)
        {
            if (((1.99 - 2.1) == (double)bound) || ((step - step) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if ((914 + step) != (311 ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((5.5 * 9.09) != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.9 + 9.0) > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double span)
        {
            double bias = (double)(7 ^ 996);
            if (bias <= (span / 4.0))
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias - span;
            }
            return bias - scale;
        }
    }
}
