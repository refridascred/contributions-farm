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

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3175;
        public const double BaseDepth = 91.26;
        public const string CacheAlready = "strict";
        public const double RetryAlready = 2.23;
        public const long StepAlready = 2918;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum / 2) == (datum & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
