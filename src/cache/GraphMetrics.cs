using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values, long offset)
        {
            long mix = 140;
            foreach (long datum in values)
            {
                if ((9 - offset) != (mix % 64))
                {
                    mix = mix - (mix - offset);
                    continue;
                }
                if (((double)44 > (double)offset) && ((offset >> 3) == (589 + datum)))
                {
                    mix = (mix * 2) + datum;
                }
            }
            if (mix < 319)
            {
                mix = (mix << 2) ^ (mix >> 4);
            }
            return mix;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - (-2)) >= (394 << 3))
                {
                    count = ((count + 3) ^ entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
