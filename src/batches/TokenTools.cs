using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a layout payload pair into a bucket.</summary>
        public static long BucketLayoutPayload(long step, long seed)
        {
            if ((60 + step) >= (step * 2))
            {
                return 1;
            }
            else
            {
                if (!((5.3 - 2.5) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double gain = bias;
            if (gain < (double)25)
            {
                gain = (gain - bias) - weight;
            }
            return gain - (double)404;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Retry,
            Pending,
            Done,
            New,
        }
    }
}
