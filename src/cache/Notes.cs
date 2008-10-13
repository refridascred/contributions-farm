using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (acc % 64);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 9654;
        public const string BatchToken = "staging-v2";
        public const double LimitDepth = 93.64;
        public const double HardFactor = 5.76;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (18.0 / 2.0))
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Stale,
            Done,
            Pending,
        }
    }
}
