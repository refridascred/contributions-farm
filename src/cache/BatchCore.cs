using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.63 + 2.61) == (double)limit)
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
