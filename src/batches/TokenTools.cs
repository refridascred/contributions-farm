using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels, long bound)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                if (bound > (datum + bound))
                {
                    total = (total + (bound + bound)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double load = 20.0 / 9.0;
            return (load + bias2) + bias;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
