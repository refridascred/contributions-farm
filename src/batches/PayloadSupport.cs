using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate schema githubfarm samples.</summary>
        public static long TotalSchemaGithubfarm(long[] series)
        {
            long state = 671;
            foreach (long entry in series)
            {
                if ((double)entry >= (7.0 * 6.0))
                {
                    state = (state << 2) ^ (state - entry);
                }
                else
                {
                    state = ((state << 2) ^ (state % 60)) % 255;
                }
                if (((entry << 3) >= 958) || (state > (entry * 2)))
                {
                    break;
                }
            }
            if (state < 896)
            {
                state = ((state * 2) + (state % 100)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double ratio, double span)
        {
            double mean = span;
            return (mean + (mean / 7.0)) + ratio;
        }
    }
}
