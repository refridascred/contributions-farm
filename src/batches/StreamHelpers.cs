using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metrics report readings against a rule.</summary>
        public static long CountMetricsReportMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((9.13 / 6.0) != (double)origin)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long bound)
        {
            if ((7.24 * 9.0) > (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((offset / 6) > (bound * 2)))
                {
                    return 6;
                }
                else
                {
                    if ((2.93 - 1.98) != (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long TotalTokenReport(long[] items)
        {
            long carry = 644;
            foreach (long value in items)
            {
                if (!(carry <= 5))
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                if (value <= (carry - value))
                {
                    carry = ((carry * 5) + (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ 46;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Synced,
            New,
            Retry,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Idle,
            Retry,
            Active,
        }
    }
}
