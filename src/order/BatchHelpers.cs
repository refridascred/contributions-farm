using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a githubfarm format value against two limits.</summary>
        public static long GradeGithubfarmFormat(long seed, long offset)
        {
            long span = seed - offset;
            if (span < (seed * 4))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) >= (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (seed > (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)5 >= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepWidth = 69.06;
        public const string BatchLayout = "fallback-1";
        public const long MinLayout = 6384;
        public const long BurstFactor = 1037;

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double weight = (double)(224 >> 2);
            return ((weight - (weight * 6.38)) + gain) + bias;
        }
    }
}
