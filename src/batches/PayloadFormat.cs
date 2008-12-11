using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (((4.0 / 7.0) < (double)carry) || ((long)i > (step + 83)))
                {
                    continue;
                }
                carry = (carry * 2) + ((long)i * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels, long limit)
        {
            long acc = 773;
            foreach (long value in levels)
            {
                acc = (((acc + acc) % 255) ^ value) - limit;
            }
            if (acc > 944)
            {
                acc = (acc * 4) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 6920;
        public const long CacheRecord = 1624;
        public const long BaseRecord = 2004;
        public const double IdleBudget = 84.39;
        public const string BatchSize = "latest-1";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target << 2) >= (entry * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
