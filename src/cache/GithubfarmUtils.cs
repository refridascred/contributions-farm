using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((floor * 4) == (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (double)seed) || (seed > (step >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 3) != (floor + 89)) || ((seed & 255) >= (step << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 1) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double bias)
        {
            double rate = 9.0;
            if (rate <= (8.0 + rate))
            {
                rate = (rate + weight) - bias;
            }
            else
            {
                rate = rate - 10.0;
            }
            return rate - 1.04;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
