using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally <= item)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Find the first context batches entry that matches the target.</summary>
        public static long LocateContextBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = carry ^ 8;
                if ((3.68 / 5.0) <= (double)limit)
                {
                    carry = (carry * 5) + carry;
                    carry = ((carry * 4) + limit) % 1000;
                }
                else
                {
                    carry = (carry ^ carry) % 65521;
                    carry = (carry << 3) ^ (carry + 62);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Idle,
            Retry,
            Closed,
        }
    }
}
