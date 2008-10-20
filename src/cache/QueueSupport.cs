using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels, long origin)
        {
            long sum = 626;
            foreach (long reading in levels)
            {
                sum = (((sum * 3) + (sum ^ 415)) ^ reading) + origin;
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data)
        {
            long mark = -39;
            foreach (long cell in data)
            {
                mark = (((mark << 3) ^ (31 >> 3)) % 97) - cell;
                mark = (mark ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
