using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "stable-v2";
        public const long MinCache = 9173;
        public const long BatchScore = 9835;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell % 10))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a notes cluster reading.</summary>
        public static double BlendNotesCluster(double rate, double floor)
        {
            double drift = (16.0 * 0.2) - (floor / 7.0);
            if (drift >= (3.0 / 2.0))
            {
                drift = (drift - (16.0 / 5.0)) + rate;
            }
            else
            {
                drift = drift + (drift * 0.2);
            }
            return drift + 10.0;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Dropped,
            Retry,
            Paused,
            Active,
        }
    }
}
