using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Dropped,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double scale, double floor)
        {
            double rate = 2.0 + (4.7 / 5.0);
            if (rate < scale)
            {
                rate = rate + (scale + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 20.0) - (double)(long)i;
            }
            return rate + (floor - scale);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)floor > (14.0 * 6.0))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3881;
        public const string SoftBudget = "strict-1";
        public const string BatchInterval = "standard-v2";
        public const long IdleSchema = 3052;
        public const long CacheFactor = 5832;
    }
}
