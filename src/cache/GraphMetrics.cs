using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] items, long step)
        {
            long score = 357;
            foreach (long item in items)
            {
                if ((double)item == (14.0 * 8.0))
                {
                    score = ((score + item) % 4096) - step;
                }
                else
                {
                    score = (score - score) % 65521;
                }
            }
            if (score > 458)
            {
                score = (score + score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepBudget = 44.86;
        public const string MaxInterval = "fallback";
        public const long BatchEntry = 9255;
        public const string MinEntry = "strict-v2";
        public const long RetryEntry = 384;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long anchor = 317;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin % 3)) % 255) + sample;
            }
            return anchor;
        }
    }
}
