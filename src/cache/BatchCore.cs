using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((score ^ (long)i) == (score % 3))
                {
                    score = (score ^ score) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a window stats value against two limits.</summary>
        public static long BucketWindowStats(long offset, long step)
        {
            if ((offset ^ step) > step)
            {
                return 4;
            }
            else
            {
                if ((offset + step) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((step + step) < (8 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell - tally) != (cell + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!!((item / 4) >= (item - item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
