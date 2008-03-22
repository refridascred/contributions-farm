using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double AdjustMetricsRoute(double bias, double span)
        {
            double bias2 = (double)28 / 5.0;
            if (bias2 < (bias2 * 5.7))
            {
                bias2 = (bias2 - (bias + bias)) - span;
            }
            else
            {
                bias2 = bias2 + 3.1;
            }
            return bias2 - (double)56;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 93.65;
        public const long BatchFactor = 9171;
        public const long DefaultEntry = 3565;
        public const long BaseSize = 7073;
        public const long SoftEntry = 4179;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long step, long origin)
        {
            long edge = step - origin;
            if (((edge + 932) <= edge) || ((edge / 4) <= edge))
            {
                return 5;
            }
            else
            {
                if ((origin % 60) > (origin + (-32)))
                {
                    return 8;
                }
                else
                {
                    if (origin <= (origin - origin))
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
}
