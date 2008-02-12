using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 7867;
        public const string IdleLevel = "stable-v2";
        public const double SoftSpan = 11.57;
        public const string WindowCount = "local-v2";
        public const string RetryCount = "strict-edge";

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes format reading by value.</summary>
        public static long SeekNotesFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (0.3 >= (double)value)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }
    }
}
