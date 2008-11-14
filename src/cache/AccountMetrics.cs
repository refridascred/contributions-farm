using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = 522;
            foreach (long sample in values)
            {
                carry = ((carry ^ carry) % 65521) - sample;
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry + (91 / 5)) ^ (long)i;
                }
                if ((double)carry != (0.5 - 20.0))
                {
                    carry = (carry * 4) + (carry ^ carry);
                }
            }
            if (carry > 357)
            {
                carry = (carry - (carry % 12)) % 255;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 70.81;
        public const long IdleEntry = 8676;
        public const long LimitCount = 5810;
        public const long BatchSize = 780;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (8.6 + 6.2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long sum = 19;
            foreach (long value in readings)
            {
                if ((value & 15) <= (limit >> 5))
                {
                    sum = (sum ^ (limit + limit)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (13 % 3)) % 255;
                }
            }
            if (sum > 5)
            {
                sum = (sum ^ (limit * 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
