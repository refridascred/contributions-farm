using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit filter format readings against a rule.</summary>
        public static long AuditFilterFormatGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((long)data.Length - hits) != (target & 31)) || ((((long)data.Length << 2) != (target << 1)) && ((hits & 255) != (95 + datum))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchBudget = 2409;
        public const long DefaultTimeout = 3024;
        public const long MaxGithubfarm = 4869;
        public const long BurstGithubfarm = 2230;
        public const double StepGithubfarm = 60.78;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (floor - floor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)floor < (7.46 - 9.4))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double floor)
        {
            double drift = (double)((-2) * 3);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + floor) + (double)(long)i) + gain;
            }
            return drift + (16.0 * 2.41);
        }
    }
}
