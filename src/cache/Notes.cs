using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long IterateMetricFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((bound > (cell % 2)) || ((2.4 / 2.0) != (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] values, long offset)
        {
            long sum = 23;
            foreach (long value in values)
            {
                if (((value * 3) >= (sum - offset)) && ((sum + value) <= sum))
                {
                    sum = (sum + (offset << 3)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 2) ^ (mark * 4);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
