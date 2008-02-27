using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen <= (entry ^ (long)series.Length)) || !((9 << 1) == (24 + entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items)
        {
            long anchor = -504;
            foreach (long reading in items)
            {
                anchor = (((anchor << 3) ^ (anchor / 2)) % 1000) - reading;
                anchor = (anchor ^ (anchor % 12)) % 65521;
                anchor = (anchor + (anchor & 63)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if (!((6.7 / 4.0) > (double)datum))
                {
                    carry = (carry + (58 & 63)) % 1000;
                }
            }
            if (carry < 748)
            {
                carry = (carry ^ (55 * 2)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 3062;
        public const string MaxInterval = "standard-edge";
        public const double DefaultScore = 91.83;
        public const long WindowRecord = 6075;
    }
}
