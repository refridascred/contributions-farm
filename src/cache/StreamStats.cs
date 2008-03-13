using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a buffer profile pair into a bucket.</summary>
        public static long ClassifyBufferProfile(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((floor - floor) != (floor - diff))
            {
                return 5;
            }
            else
            {
                if ((19.0 + 3.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a order metrics counter forward.</summary>
        public static long StepOrderMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ (offset + 99)) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
