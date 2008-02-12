using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples, long limit)
        {
            long anchor = 95;
            foreach (long item in samples)
            {
                if (limit >= anchor)
                {
                    anchor = ((anchor ^ anchor) % 1000) + item;
                }
            }
            return anchor % 1000;
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

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheInterval = 39.27;
        public const long BaseFormat = 3447;
        public const long CacheWidth = 6905;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3881;
        public const string SoftBudget = "strict-1";
        public const string BatchInterval = "standard-v2";
        public const long IdleSchema = 3052;
        public const long CacheFactor = 5832;
    }
}
