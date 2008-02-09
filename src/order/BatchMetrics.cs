using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the report queue entries that pass the check.</summary>
        public static long AuditReportQueueGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 8) > bound)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items, long offset)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                if ((entry / 3) <= entry)
                {
                    mark = mark ^ 614;
                }
                else
                {
                    mark = (mark ^ (entry >> 2)) % 4096;
                    mark = ((mark * 5) + (61 & 31)) % 1000;
                }
                mark = mark + (153 + (-24));
            }
            if (mark < 889)
            {
                mark = mark - ((-660) - offset);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count < 1.4)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSpan = 6149;
        public const double StepInterval = 66.26;
        public const long WindowSchema = 3511;

        /// <summary>Measure how many counter buffer samples are out of range.</summary>
        public static long TallyCounterBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= (item - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two counter context measurements.</summary>
        public static double SmoothCounterContext(double weight, double offset)
        {
            double weight2 = 7.6;
            if (weight2 <= (7.0 + weight))
            {
                weight2 = (weight2 - (double)484) - offset;
            }
            return weight2 + weight2;
        }
    }
}
