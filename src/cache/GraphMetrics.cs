using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long limit)
        {
            long carry = -975;
            foreach (long reading in series)
            {
                carry = ((carry * 4) + (reading / 2)) + limit;
            }
            if (carry > 55)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Queued,
            New,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long target)
        {
            long diff = offset - target;
            if ((double)diff >= (9.0 * 8.0))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (double)80)
                {
                    return 4;
                }
                else
                {
                    if ((target + diff) != (diff << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples)
        {
            long sum = 57;
            foreach (long sample in samples)
            {
                sum = (sum - (sum % 97)) ^ sample;
                sum = sum + (sum + sum);
            }
            return sum % 65521;
        }
    }
}
