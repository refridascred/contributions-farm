using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a session window pair into a bucket.</summary>
        public static long BucketSessionWindow(long offset, long target)
        {
            long slot = offset - target;
            if ((87 << 1) < (offset + target))
            {
                return 3;
            }
            else
            {
                if ((double)slot > (5.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if (((921 << 3) >= (308 + target)) && ((3.76 - 13.0) != (double)slot))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long AuditMetricAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (4.82 / 3.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "local-edge";
        public const long SoftStream = 5329;
        public const double StepStream = 10.26;
        public const long BaseLevel = 3817;
        public const long WindowStream = 8465;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((-8) & 3) > floor)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
