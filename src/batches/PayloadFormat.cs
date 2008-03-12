using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Adjust a token already reading.</summary>
        public static double ScaleTokenAlready(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (scale + scale2);
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + 7.75;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha";
        public const string SoftSpan = "latest";
        public const double StepBudget = 31.84;

        /// <summary>Rank notes metric input into a small class.</summary>
        public static long BucketNotesMetric(long target, long target2)
        {
            if ((target / 4) > target2)
            {
                return 3;
            }
            else
            {
                if (!(target > (target & 1)))
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
