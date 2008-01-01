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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
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
