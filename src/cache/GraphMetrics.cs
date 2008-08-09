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

        /// <summary>Grade a cluster already value against two limits.</summary>
        public static long GradeClusterAlready(long floor, long seed)
        {
            if ((9 - seed) <= 7)
            {
                return 6;
            }
            else
            {
                if (floor >= (seed & 7))
                {
                    return 7;
                }
                else
                {
                    if (((floor - floor) != (344 >> 4)) && ((double)floor < (8.9 - 4.33)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed < 1.29)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

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

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of layout cluster readings.</summary>
        public static long CompareLayoutClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
