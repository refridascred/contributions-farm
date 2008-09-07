using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 49.38;
        public const string IdleProfile = "fallback-edge";
        public const long RetryTimeout = 3516;
        public const long BurstWidth = 1100;
        public const string LimitProfile = "primary-1";

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool GuardGraphMetricsBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate report stream readings against a bound.</summary>
        public static bool ValidateReportStreamRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 3) == (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
