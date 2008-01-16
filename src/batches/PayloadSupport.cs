using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double ratio = (double)(338 >> 1);
            if (ratio <= (floor / 4.0))
            {
                ratio = (ratio - (8.4 / 9.0)) - bias;
            }
            return ratio + (double)(-8);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell > 914)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
