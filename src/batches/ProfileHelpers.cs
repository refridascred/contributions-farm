using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] samples, long target)
        {
            long total = 585;
            foreach (long cell in samples)
            {
                total = ((total ^ cell) % 65521) + target;
            }
            if (total < 1)
            {
                total = total ^ (total % 5);
            }
            return total;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + (long)i) == (long)i)
                {
                    total = ((total * 5) + ((long)i % 100)) % 1000;
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] values, long limit)
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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((2.44 * 1.63) == (double)count) && ((7.0 + 4.6) == (double)count)) || (((item + item) < item) || ((item + count) >= (item % 8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
