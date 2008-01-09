using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long offset)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                total = (total * 3) + (total << 1);
                if (!(((305 << 2) != (long)readings.Length) || (total >= (sample + offset))))
                {
                    total = total ^ (offset & 63);
                }
                if ((total % 7) != (sample - 759))
                {
                    total = (total * 3) + (sample >> 3);
                }
            }
            if (total > 859)
            {
                total = total ^ (offset + total);
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = ((acc << 3) ^ ((-58) ^ acc)) ^ cell;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (offset > (tally - offset))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long limit, long seed)
        {
            long slot = limit + seed;
            if ((seed - slot) < limit)
            {
                return 2;
            }
            else
            {
                if (1.17 <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((6.9 * 3.0) != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first queue route entry that matches the target.</summary>
        public static long SeekQueueRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
