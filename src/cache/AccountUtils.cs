using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data)
        {
            long carry = 67;
            foreach (long reading in data)
            {
                if ((reading & 127) >= (7 + carry))
                {
                    carry = (carry - (carry * 2)) % 65521;
                }
            }
            if (carry > 533)
            {
                carry = ((carry << 2) ^ (carry >> 4)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Measure how many metric buffer samples are out of range.</summary>
        public static long TallyMetricBufferHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits - origin) > (hits & 127)) || ((8 & 1) == (reading & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Stale,
            Closed,
            Draft,
            Done,
        }
    }
}
