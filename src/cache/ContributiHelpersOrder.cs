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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
