using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a report account sample.</summary>
        public static long LocateReportAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = (double)(32 ^ 2);
            if (mean < (ratio + ratio))
            {
                mean = mean - (floor / 8.0);
            }
            return mean + mean;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Queued,
            Synced,
            Retry,
        }
    }
}
