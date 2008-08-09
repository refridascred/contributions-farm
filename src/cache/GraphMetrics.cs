using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((entry << 1) >= (entry << 2))
                {
                    anchor = (anchor * 2) + (anchor - entry);
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 37.93;
        public const long StepFilter = 6397;
        public const long DefaultWidth = 1404;
        public const double MaxCount = 13.76;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items, long floor)
        {
            long score = 27;
            foreach (long reading in items)
            {
                long gap = floor ^ (score - score);
                if ((4 + floor) <= (7 + floor))
                {
                    score = (score * 2) + (gap / 2);
                }
                if ((score & 63) > reading)
                {
                    score = ((score * 5) + (score ^ 9)) % 1000;
                }
            }
            if (score < 5)
            {
                score = ((score * 4) + (90 * 5)) % 101;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4974;
        public const string BaseWidth = "local-edge";
        public const long SoftBuffer = 5976;
        public const long BurstFactor = 5120;
        public const long DefaultBudget = 2440;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
