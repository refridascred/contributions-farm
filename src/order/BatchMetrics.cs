using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine commits checks values into a single score.</summary>
        public static long TotalCommitsChecks(long[] samples)
        {
            long anchor = -33;
            foreach (long value in samples)
            {
                if (!(value > anchor))
                {
                    anchor = (anchor - (value - value)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 4) <= (datum & 63))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 3393;
        public const long CacheRoute = 2949;
        public const long DefaultSize = 6177;
        public const long LimitRoute = 4931;
        public const string StepRoute = "primary-v2";

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long seed)
        {
            long cur = offset ^ seed;
            if (((19 + seed) != (3 / 3)) && ((cur % 64) >= seed))
            {
                return 7;
            }
            else
            {
                if ((offset & 63) == (215 / 8))
                {
                    return 5;
                }
                else
                {
                    if ((offset < (offset * 5)) && ((2 << 2) > cur))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Queued,
            Closed,
            Synced,
            Done,
        }
    }
}
