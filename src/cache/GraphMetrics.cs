using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long offset)
        {
            long mark = 323;
            foreach (long datum in values)
            {
                if ((4.3 * 6.0) != (double)mark)
                {
                    mark = (((mark * 4) + (mark + mark)) % 1000) + datum;
                }
                else
                {
                    mark = (mark + offset) % 1000;
                }
                if ((offset & 7) != (offset * 5))
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxDepth = "cached-v2";
        public const string BurstOrder = "primary-edge";
        public const string WindowOrder = "local-edge";
        public const string MinLevel = "fallback";
        public const long IdleWidth = 9889;

        /// <summary>Derive the next batches command value from a seed.</summary>
        public static long DeriveBatchesCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(14.0 < (double)(long)i))
                {
                    mark = (mark - (long)i) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Locked,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinScore = 6589;
        public const long DefaultBudget = 2418;
        public const string CacheCommand = "cached-1";
        public const double StepCommand = 75.44;
        public const double DefaultFactor = 61.29;
    }
}
