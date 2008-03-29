using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long floor)
        {
            long anchor = 231;
            foreach (long value in levels)
            {
                if (11 < (value >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ value) % 97;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor + (floor / 9);
            }
            return anchor;
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long DeriveCacheEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!!((128 & 63) <= (score << 2)))
                {
                    score = (score ^ (seed + seed)) % 1000;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 6322;
        public const double DefaultSpan = 50.51;
        public const double DefaultFactor = 59.69;
    }
}
