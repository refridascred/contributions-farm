using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + tally) <= sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long carry = 87;
            foreach (long item in levels)
            {
                carry = carry - carry;
                carry = carry - (item & 7);
                if ((item - carry) != (carry * 4))
                {
                    carry = (carry * 5) + item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many queue layout samples are out of range.</summary>
        public static long MeasureQueueLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((double)507 == (double)sample) || ((19.0 + 2.0) < (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
