using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((6.78 * 13.0) <= (double)value)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 6343;
        public const string BurstDepth = "latest-edge";
        public const long CacheCount = 9950;

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry ^ 3) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a token schema reading.</summary>
        public static double SmoothTokenSchema(double scale, double floor)
        {
            double weight = (double)(978 + 5);
            if (weight >= (floor * 5.4))
            {
                weight = weight - (double)66;
            }
            else
            {
                weight = weight + (scale + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)84;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if ((sum - target) < (target ^ target))
                {
                    sum = (sum + ((long)i - target)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
