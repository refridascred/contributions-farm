using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count notes cluster pairs that satisfy a relation.</summary>
        public static long PairNotesClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support account sample.</summary>
        public static long LocateSupportAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] levels, long target)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                total = total + (total + target);
                if (((reading ^ target) < target) || (72 > target))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = total + ((-4) & 31);
            }
            return total;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long target)
        {
            long edge = seed - target;
            if (target <= (target + target))
            {
                return 0;
            }
            else
            {
                if (seed <= (seed / 8))
                {
                    return 5;
                }
                else
                {
                    if (((seed + target) < (target ^ target)) && ((edge / 9) > edge))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((4 + edge) >= target) && ((double)edge <= (16.0 * 6.07)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
