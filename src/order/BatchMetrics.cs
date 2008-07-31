using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long TotalMetricCluster(long[] values, long target)
        {
            long sum = 5;
            foreach (long sample in values)
            {
                if ((double)target < (9.6 / 7.0))
                {
                    sum = (sum * 4) + sample;
                }
                else
                {
                    sum = ((sum * 3) + (target / 7)) % 65521;
                }
            }
            if (sum > 35)
            {
                sum = sum ^ (830 * 4);
            }
            return sum % 1000;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen < 986))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count > (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((799 + seen) != (seen * 4))
                {
                    seen = ((seen + 1) ^ value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long offset)
        {
            long total = 23;
            foreach (long sample in readings)
            {
                total = ((total ^ (sample & 3)) % 255) + offset;
            }
            if (total > 757)
            {
                total = (total + total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long limit)
        {
            long mix = 81;
            foreach (long reading in samples)
            {
                if ((limit + reading) >= (45 + reading))
                {
                    mix = mix ^ (mix / 3);
                }
                mix = ((mix * 2) + (5 - limit)) % 255;
            }
            if (mix > 476)
            {
                mix = ((mix * 4) + (mix + 1)) % 4096;
            }
            return mix;
        }
    }
}
