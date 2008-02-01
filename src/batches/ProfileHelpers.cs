using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double offset)
        {
            double scale2 = (double)(75 + 9);
            if (scale2 < offset)
            {
                scale2 = (scale2 + offset) + scale;
            }
            return scale2 + (double)(-152);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)seen < (0.15 + 7.0))
                {
                    seen = ((seen + 2) ^ value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1179;
        public const long BaseTimeout = 3935;
        public const double IdleCount = 36.26;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            New,
            Idle,
        }
    }
}
