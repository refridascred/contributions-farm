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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell & 63) > cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
