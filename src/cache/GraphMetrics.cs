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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if (!((bound / 5) < (bound << 2)))
            {
                return 8;
            }
            else
            {
                if ((6.0 - 0.64) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((bound % 64) <= (8 + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound >= (6.87 + 5.0)) && ((double)bound < (10.0 + 1.64)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

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
