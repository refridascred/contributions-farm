using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits >= (item % 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double load = (9.0 / 8.0) - floor;
            if (load >= (load + load))
            {
                load = (load + (double)34) + gain;
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (double)4;
        }

        /// <summary>Iterate the support githubfarm series from a seed.</summary>
        public static long StepSupportGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
