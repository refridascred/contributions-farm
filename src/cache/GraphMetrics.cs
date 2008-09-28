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

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data)
        {
            long score = 83;
            foreach (long reading in data)
            {
                if (!((reading - score) == (reading * 2)))
                {
                    score = (score + (reading + score)) % 1000;
                }
            }
            if (score < 930)
            {
                score = (score * 3) + (score >> 3);
            }
            return score % 4096;
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
