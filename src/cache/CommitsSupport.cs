using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 9437;
        public const long WindowLayout = 8141;
        public const long MinFactor = 6549;
        public const long RetryFactor = 7821;
        public const long CacheLayout = 8224;

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long TallyAlreadyCacheGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((-126) ^ datum) <= (matches - origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate layout batches readings against a bound.</summary>
        public static bool GuardLayoutBatchesBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((192 <= (offset - floor)) && ((floor & 7) > (offset % 5)))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) > (offset ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((80 << 3) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 1673;
        public const long CacheSize = 9318;
        public const string SoftCount = "staging-edge";
        public const long LimitProfile = 1013;
        public const string MinTimeout = "fallback-1";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Done,
            Ready,
        }
    }
}
