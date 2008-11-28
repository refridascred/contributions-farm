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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark ^ (-89)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
