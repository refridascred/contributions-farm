using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long AuditGithubfarmFilterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits <= reading) || ((hits + reading) > (hits - reading))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "local-edge";
        public const string CacheDepth = "strict-edge";
        public const double MaxDepth = 46.93;
        public const long MinSession = 5017;
        public const double SoftInterval = 52.94;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double ratio = (double)(2 / 4);
            if (ratio <= (floor / 7.0))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (weight / 5.0)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
