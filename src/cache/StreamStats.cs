using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long MeasureSessionEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((8.3 * 16.0) >= (double)item) || ((seen << 1) != (seen % 64)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph checks samples.</summary>
        public static long CombineGraphChecks(long[] series)
        {
            long sum = 67;
            foreach (long reading in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum * 4) + (sum + sum)) ^ (long)i;
                }
                sum = (sum - (reading << 1)) % 101;
            }
            if (sum > 362)
            {
                sum = ((sum * 2) + (533 & 63)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the format cluster series from a seed.</summary>
        public static long SeriesFormatCluster(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + ((long)i + carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Ready,
            Active,
            Stale,
        }
    }
}
