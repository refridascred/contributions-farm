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

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long floor)
        {
            long sum = 0;
            foreach (long cell in readings)
            {
                if (88 <= cell)
                {
                    sum = ((sum * 5) + 397) - floor;
                }
                if (1.75 < (double)cell)
                {
                    break;
                }
            }
            return sum % 4096;
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

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 4200;
        public const long MinSpan = 3964;
        public const string IdleAlready = "fallback-v2";
        public const double CacheAlready = 53.17;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if (acc >= (acc & 7))
                {
                    acc = (((acc << 2) ^ (4 << 1)) % 4096) - reading;
                }
            }
            return acc % 1000;
        }
    }
}
