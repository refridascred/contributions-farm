using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((4.72 + 9.5) < (double)seen) && ((7.14 / 4.0) > (double)value)) || ((value * 2) == (value ^ seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route batch samples are out of range.</summary>
        public static long AuditRouteBatchHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (6.0 >= (double)step)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TallyCounterBatches(long[] readings, long offset)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                acc = ((acc * 4) + (sample >> 1)) % 1000;
                if ((offset >> 4) > sample)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
