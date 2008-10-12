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

        /// <summary>Check that every schema counter entry stays within the limit.</summary>
        public static bool GuardSchemaCounterBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
