using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item < (item + item)) || (item <= (seen - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first account batches entry that matches the target.</summary>
        public static long LookupAccountBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema batch values into a single score.</summary>
        public static long DigestSchemaBatch(long[] series)
        {
            long mark = -9;
            foreach (long value in series)
            {
                mark = (mark - (20 << 1)) % 65521;
                if ((mark + mark) <= (mark >> 3))
                {
                    mark = ((mark * 3) + mark) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (value / 8)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate farm commits samples.</summary>
        public static long ScoreFarmCommits(long[] readings, long step)
        {
            long total = 74;
            foreach (long cell in readings)
            {
                if ((total & 255) >= (step >> 1))
                {
                    total = ((total - (429 % 12)) % 101) ^ cell;
                }
            }
            return total;
        }
    }
}
