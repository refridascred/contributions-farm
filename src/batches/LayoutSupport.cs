using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long seed)
        {
            if (92 < seed)
            {
                return 4;
            }
            else
            {
                if ((2.3 + 9.3) < (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((step / 6) > seed) || ((double)seed != (8.0 * 5.59)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowScore = "fallback";
        public const long SoftFactor = 1899;
        public const long DefaultAlready = 6395;
        public const long BaseAlready = 9463;

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (bias / 9.0))
            {
                scale = scale + (scale / 6.0);
            }
            return scale - 5.62;
        }

        /// <summary>Validate cache window readings against a bound.</summary>
        public static bool ValidateCacheWindowRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardInterval = 30.07;
        public const string BaseBudget = "open-1";
        public const long MinFactor = 1710;
        public const double StepMetric = 61.63;
    }
}
