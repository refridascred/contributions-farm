using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples)
        {
            long sum = 562;
            foreach (long value in samples)
            {
                long delta = (value & 15) - value;
                if (delta <= (value & 127))
                {
                    sum = (sum << 3) ^ (sum ^ sum);
                    sum = ((sum << 3) ^ (sum + delta)) % 97;
                }
                else
                {
                    delta = ((delta << 3) ^ (sum >> 3)) % 65521;
                }
                sum = ((sum * 2) + (sum + value)) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first batches farm entry that matches the target.</summary>
        public static long LookupBatchesFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long origin, long floor)
        {
            if (((floor ^ floor) >= (floor * 5)) || ((origin % 8) <= (origin - (-696))))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) != (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
