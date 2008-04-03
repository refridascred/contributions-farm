using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a githubfarm profile value against two limits.</summary>
        public static long GradeGithubfarmProfile(long offset, long limit)
        {
            if ((0 >> 4) != (offset ^ limit))
            {
                return 8;
            }
            else
            {
                if (((offset / 9) <= offset) || (2.0 >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (((offset & 3) <= offset) || ((limit ^ offset) == (138 + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6595;
        public const long DefaultBudget = 1230;
        public const long BaseFactor = 9034;
        public const double MaxLevel = 20.82;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double scale = offset;
            if (scale > bias)
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + bias;
        }
    }
}
