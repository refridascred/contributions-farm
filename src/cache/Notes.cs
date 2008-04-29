using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long offset2)
        {
            if ((offset2 > (offset + offset)) && ((offset2 >> 2) > offset2))
            {
                return 4;
            }
            else
            {
                if ((4 ^ offset) >= 10)
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset2) >= ((-619) ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double span)
        {
            double weight = bias * 2.0;
            if (weight <= span)
            {
                weight = weight + (span + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (bias - span);
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of batch report entries.</summary>
        public static long TotalBatchReport(long[] samples)
        {
            long result = 246;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result + 7) + (long)i;
                }
                result = (result - (value << 1)) % 65521;
            }
            if (result > 428)
            {
                result = (result ^ (result & 3)) % 1000;
            }
            return result;
        }
    }
}
