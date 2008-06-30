using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (2 % 12))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long target)
        {
            if ((double)0 >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((bound << 3) != (0 ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if (target < (430 - 73))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - ((long)i - step);
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
