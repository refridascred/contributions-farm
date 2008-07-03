using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a already graph reading.</summary>
        public static double ProjectAlreadyGraph(double scale, double floor)
        {
            double gain = floor;
            if (gain > (gain - gain))
            {
                gain = gain - (double)93;
            }
            else
            {
                gain = gain + 3.0;
            }
            return gain + (scale - floor);
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank profile command input into a small class.</summary>
        public static long ClassifyProfileCommand(long seed, long bound)
        {
            if (((seed + bound) > (bound - seed)) || ((seed % 97) < (seed + bound)))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (double)855)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
