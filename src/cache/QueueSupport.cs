using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel metric input into a small class.</summary>
        public static long BucketChannelMetric(long seed, long offset)
        {
            if ((offset << 3) != (offset / 5))
            {
                return 7;
            }
            else
            {
                if (7.58 >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!((14.0 * 5.9) <= (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels)
        {
            long sum = 346;
            foreach (long reading in levels)
            {
                if ((sum ^ reading) >= (sum - sum))
                {
                    sum = ((sum << 3) ^ (reading * 5)) % 1000;
                }
            }
            if (sum > (-112))
            {
                sum = sum ^ (3 % 7);
            }
            return sum;
        }
    }
}
