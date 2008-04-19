using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two command commits measurements.</summary>
        public static double ProjectCommandCommits(double bias, double floor)
        {
            double gain = bias;
            if (gain < (bias / 6.0))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) - (double)(long)i;
            }
            return gain - floor;
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
