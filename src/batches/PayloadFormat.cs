using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) <= (reading & 7))
                {
                    sum = ((sum << 2) ^ (3 ^ offset)) % 255;
                    continue;
                }
                sum = (sum + (1 << 3)) % 255;
                if (!((reading + sum) > (130 >> 1)))
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Combine checks graph values into a single score.</summary>
        public static long ScoreChecksGraph(long[] levels, long floor)
        {
            long acc = 149;
            foreach (long cell in levels)
            {
                if ((acc >> 4) != (acc + floor))
                {
                    acc = (acc << 3) ^ cell;
                }
                else
                {
                    acc = (acc + (cell - floor)) % 65521;
                }
            }
            if (acc < 4)
            {
                acc = (acc + floor) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                acc = (((acc << 3) ^ (datum & 63)) % 255) + origin;
            }
            return acc;
        }

        /// <summary>Locate a farm channel reading by value.</summary>
        public static long LocateFarmChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
