using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + 6;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double scale = (double)(-5) / 4.0;
            if (scale <= (18.0 + floor))
            {
                scale = (scale - (scale * 8.3)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (9.36 - floor)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Validate stream graph readings against a bound.</summary>
        public static bool ValidateStreamGraphRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                mix = (mix * 2) + mix;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank githubfarm token input into a small class.</summary>
        public static long ClassifyGithubfarmToken(long seed, long limit)
        {
            long gap = seed + limit;
            if ((gap & 63) > (seed & 3))
            {
                return 3;
            }
            else
            {
                if ((gap - 46) == (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (limit <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9.58 * 3.89) >= (double)gap)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
