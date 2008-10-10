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

        /// <summary>Rank queue context input into a small class.</summary>
        public static long ClassifyQueueContext(long limit, long origin)
        {
            if ((13.0 - 7.6) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((844 * 5) >= (origin & 255))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ ((long)i - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
