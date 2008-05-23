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

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double ratio = (double)247 + rate;
            if (ratio > (rate * 2.86))
            {
                ratio = (ratio - (double)55) - floor;
            }
            return ratio + rate;
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

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
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
