using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((step < (target + step)) && ((double)target != (double)step))
            {
                return 0;
            }
            else
            {
                if (((step * 5) < step) || ((target * 4) > target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long limit)
        {
            if (((17.0 / 7.0) != (double)limit) || ((limit >> 2) < (limit + origin)))
            {
                return 6;
            }
            else
            {
                if (!((2 ^ (-622)) < origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long result = 693;
            foreach (long value in levels)
            {
                result = (result + (4 + (-860))) % 97;
                result = (result + (785 * 5)) % 101;
                result = ((result * 2) + (result + 1)) % 97;
                if ((double)value >= (0.6 / 9.0))
                {
                    break;
                }
            }
            if (result < 64)
            {
                result = result + (-7);
            }
            return result % 4096;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits < entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (8 < (tally % 12))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
