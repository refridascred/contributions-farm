using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every githubfarm buffer entry stays within the limit.</summary>
        public static bool GuardGithubfarmBufferBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((5.4 * 0.4) > (double)offset)
                {
                    long matches = offset >> 5;
                    score = (score * 3) + (score - matches);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a route payload reading.</summary>
        public static double SmoothRoutePayload(double ratio, double span)
        {
            double rate = (double)(771 << 2);
            if (rate > span)
            {
                rate = (rate - (double)60) + ratio;
            }
            return rate - (span * 13.0);
        }
    }
}
