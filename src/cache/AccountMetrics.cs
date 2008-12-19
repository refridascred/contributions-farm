using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (7.0 < (double)cell)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double drift = (double)(53 + 99);
            return ((drift + drift) + ratio) + floor;
        }

        /// <summary>Fold a list of batch account readings.</summary>
        public static long ScoreBatchAccount(long[] data, long floor)
        {
            long sum = 66;
            foreach (long value in data)
            {
                if (((913 ^ value) < (value + value)) || (((-541) / 5) < (sum >> 5)))
                {
                    sum = ((sum - (sum ^ sum)) % 255) + floor;
                }
                sum = ((sum * 2) + (value + 99)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Closed,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 365) <= (hits << 1))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 5.99;
        public const long SoftSpan = 709;
        public const long RetrySchema = 4003;
        public const long SoftSchema = 8134;
    }
}
