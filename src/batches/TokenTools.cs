using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank stream route input into a small class.</summary>
        public static long ClassifyStreamRoute(long bound, long seed)
        {
            if (((double)bound >= 6.8) && ((bound >> 4) < bound))
            {
                return 7;
            }
            else
            {
                if ((seed >> 2) <= (737 + seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Pending,
            Closed,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double mean = offset / 2.0;
            if (mean <= (mean / 9.0))
            {
                mean = (mean - (offset - mean)) - weight;
            }
            return mean + offset;
        }
    }
}
