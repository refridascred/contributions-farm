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

        /// <summary>Compare every pair of cluster already readings.</summary>
        public static long CompareClusterAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
