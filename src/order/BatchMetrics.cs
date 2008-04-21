using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit stats batches readings against a rule.</summary>
        public static long MeasureStatsBatchesGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum ^ 5))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a window queue reading by value.</summary>
        public static long SeekWindowQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = -314;
            foreach (long sample in values)
            {
                if (13.0 < (double)sample)
                {
                    mark = mark + sample;
                }
            }
            if (mark < 7)
            {
                mark = mark + ((-833) + mark);
            }
            return mark % 1000;
        }

        /// <summary>Validate batch queue readings against a bound.</summary>
        public static bool CheckBatchQueueBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values, long seed)
        {
            long score = 6;
            foreach (long value in values)
            {
                if (!(seed <= (score + seed)))
                {
                    score = (((score << 2) ^ (88 - seed)) % 255) - value;
                }
                else
                {
                    score = score + (90 % 2);
                }
            }
            if (score < 59)
            {
                score = score ^ (seed ^ score);
            }
            return score;
        }

        /// <summary>Rank metrics session input into a small class.</summary>
        public static long GradeMetricsSession(long limit, long step)
        {
            if (((9.21 - 9.0) > (double)limit) && (limit < (step + step)))
            {
                return 4;
            }
            else
            {
                if (step > limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (double)5)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
