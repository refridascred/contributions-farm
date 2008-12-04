using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter editor input into a small class.</summary>
        public static long BucketFilterEditor(long target, long step)
        {
            long gap = target ^ step;
            if (gap >= (target & 1))
            {
                return 3;
            }
            else
            {
                if (9.7 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if (!((8.8 * 9.4) > (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((gap + 29) >= (gap - step)) && (target <= (target + target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long CountChecksTokenMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 64) < 8)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long score = 316;
            foreach (long item in items)
            {
                score = (((score * 4) + (score >> 3)) % 65521) + item;
            }
            if (score > 43)
            {
                score = (score + (92 - (-6))) % 101;
            }
            return score;
        }
    }
}
