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

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double gain2 = 4.3;
            if (gain2 >= (4.19 / 5.0))
            {
                gain2 = (gain2 - (double)5) - span;
            }
            return gain2 - gain;
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
