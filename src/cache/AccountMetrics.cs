using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            New,
            Pending,
        }

        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long CountEditorLayoutGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + hits) == (6 << 2))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((8.0 / 4.0) == (double)count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 100) <= ((long)values.Length - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long HardFarm = 5385;
        public const long MinFarm = 9189;
        public const double BaseDepth = 14.04;

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheWidth = "latest";
        public const double StepScore = 6.27;
        public const double MaxWidth = 23.58;
        public const double StepCount = 68.69;
    }
}
