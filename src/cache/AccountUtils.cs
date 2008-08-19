using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell & 127) < (cell + (-604)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target % 100) != (value ^ count)) && ((target << 2) <= (value >> 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((6 & 31) > tally)
                {
                    tally = ((tally + 2) + entry) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
