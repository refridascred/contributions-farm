using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Idle,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value ^ value) > (value / 3)) && ((double)value < (6.37 + 9.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((double)entry < (3.12 / 8.0))
                {
                    sum = ((sum * 3) + entry) - bound;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Stale,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count == (6.87 - 2.98))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
