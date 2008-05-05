using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((17 << 3) >= ((long)readings.Length >> 5))
                {
                    count = ((count + 3) + cell) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 1606;
        public const long LimitWindow = 9057;
        public const long MaxTimeout = 1936;
        public const long BaseWindow = 3925;
        public const string HardBudget = "alpha-1";

        /// <summary>Measure how many already channel samples are out of range.</summary>
        public static long CountAlreadyChannelGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= 518)
                {
                    seen = ((seen + 1) + cell) - step;
                }
            }
            return seen;
        }
    }
}
