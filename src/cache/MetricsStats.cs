using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2.8 + 9.75) >= (double)offset)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 3) + limit;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 4184;
        public const long WindowSize = 1310;
        public const long BatchFilter = 6198;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] levels)
        {
            long score = 45;
            foreach (long sample in levels)
            {
                score = (score ^ (sample % 5)) % 255;
                if (score > (7 * 2))
                {
                    score = score - (sample - sample);
                }
            }
            return score % 65521;
        }
    }
}
