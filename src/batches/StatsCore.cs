using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank filter schema input into a small class.</summary>
        public static long RankFilterSchema(long step, long floor)
        {
            long offset = step + floor;
            if (!(floor < (floor + 3)))
            {
                return 2;
            }
            else
            {
                if (((floor % 60) == (offset - step)) && ((offset - offset) < (140 & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (3.9 - 5.1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((8.6 - 6.7) > (double)origin)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a order buffer pair into a bucket.</summary>
        public static long GradeOrderBuffer(long step, long origin)
        {
            if (((-9) - origin) < (step % 10))
            {
                return 8;
            }
            else
            {
                if ((origin - step) >= 35)
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 2) > (33 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every filter githubfarm entry stays within the limit.</summary>
        public static bool GuardFilterGithubfarmLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
