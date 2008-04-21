using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load - (4.28 / 2.0);
        }

        /// <summary>Audit schema context readings against a rule.</summary>
        public static long CountSchemaContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((6 + cell) >= (cell / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
