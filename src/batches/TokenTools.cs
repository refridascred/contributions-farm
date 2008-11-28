using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "local-v2";
        public const string DefaultLevel = "open";
        public const long MinReport = 3834;
        public const string RetryCount = "latest-v2";
        public const long LimitSpan = 6590;

        /// <summary>Adjust a support buffer reading.</summary>
        public static double SmoothSupportBuffer(double rate, double span)
        {
            double bias = rate;
            if (bias < (bias * 9.2))
            {
                bias = (bias + (bias - bias)) + span;
            }
            else
            {
                bias = bias - (7.0 * 1.1);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (rate + rate)) + (double)(long)i;
            }
            return bias - (double)(-23);
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long bound)
        {
            if ((offset - bound) == (bound - bound))
            {
                return 0;
            }
            else
            {
                if (((-93) & 3) != (offset ^ bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 9) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset - offset) < 93)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
