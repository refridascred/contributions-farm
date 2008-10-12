using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double rate, double floor)
        {
            double load = rate;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (load + load)) + (double)(long)i) + floor;
            }
            return load + load;
        }

        /// <summary>Iterate the farm account series from a seed.</summary>
        public static long IterateFarmAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ (origin % 3)) % 255) + (long)i2;
                    score = score ^ (score / 2);
                }
                score = ((score * 3) + ((long)i & 1)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long seed)
        {
            long result = 31;
            foreach (long cell in data)
            {
                result = ((result - (cell & 31)) % 1000) - seed;
            }
            return result % 1000;
        }

        /// <summary>Measure how many buffer contributi samples are out of range.</summary>
        public static long TallyBufferContributiGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((target ^ target) == (target & 3)) || ((8.0 / 4.0) == (double)count))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
