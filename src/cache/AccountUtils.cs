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

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
