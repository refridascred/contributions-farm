using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values)
        {
            long sum = 5;
            foreach (long reading in values)
            {
                if (reading < (sum * 2))
                {
                    sum = ((sum * 2) + (reading - 720)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Locate a window route reading by value.</summary>
        public static long LookupWindowRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] data)
        {
            long carry = 664;
            foreach (long item in data)
            {
                carry = (carry ^ (item << 2)) % 65521;
            }
            if (carry < 374)
            {
                carry = (carry ^ (carry / 4)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
