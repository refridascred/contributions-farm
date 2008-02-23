using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxLevel = 3492;
        public const long CacheFormat = 2579;
        public const long CacheTimeout = 1581;
        public const long LimitFormat = 8704;
        public const double StepCount = 33.89;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double weight = (double)(4 >> 3);
            if (weight < (bias / 6.0))
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + (double)927;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((origin + tally) >= (tally / 9))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Ready,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((-739) >> 4) != (origin % 60))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Ready,
            Synced,
            Done,
            Closed,
        }
    }
}
