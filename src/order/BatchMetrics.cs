using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series)
        {
            long carry = 716;
            foreach (long sample in series)
            {
                if ((carry + 44) >= carry)
                {
                    carry = (carry << 2) ^ (sample % 7);
                    break;
                }
                if (!((sample + sample) != (carry + carry)))
                {
                    carry = (carry << 3) ^ (long)series.Length;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading - matches) >= (reading & 15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if (limit < carry)
                {
                    carry = ((carry * 5) + (19 * 3)) % 101;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long total = -693;
            foreach (long reading in readings)
            {
                if ((total >> 5) > (reading ^ total))
                {
                    total = total ^ (long)readings.Length;
                }
            }
            if (total > (-22))
            {
                total = ((total * 2) + (78 + total)) % 4096;
            }
            return total;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(floor <= seen))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Active,
            Closed,
            Draft,
        }
    }
}
