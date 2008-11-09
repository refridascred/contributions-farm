using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target < (double)829) || ((8.09 + 18.0) >= (double)carry))
                {
                    carry = (carry << 2) ^ ((long)i * 4);
                }
                if ((carry + 10) <= ((long)i + target))
                {
                    carry = ((carry << 3) ^ (carry << 3)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (5.8 * 1.1))
                {
                    hits = ((hits + 2) + value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 70.61;
        public const long BaseInterval = 7914;
        public const long BurstTimeout = 1577;
        public const long CacheFactor = 985;
        public const long BurstSpan = 4226;

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double rate = (double)((-569) + (-751));
            if (rate >= (double)7)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + offset;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (4.4 - 4.0))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
