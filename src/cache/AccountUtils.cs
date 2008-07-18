using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings, long seed)
        {
            long score = 2;
            foreach (long value in readings)
            {
                if (!((8.6 * 1.0) >= (double)score))
                {
                    score = (score - (score + value)) + seed;
                }
            }
            return score;
        }

        /// <summary>Derive the next checks batches value from a seed.</summary>
        public static long IterateChecksBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!(total >= (total & 7)))
                {
                    total = total - (49 << 3);
                }
                if (total <= (total - origin))
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total * 3) + (total % 16);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next context token value.</summary>
        public static double BlendContextToken(double scale, double floor)
        {
            double ratio = (double)(864 + 971);
            if (ratio <= (double)95)
            {
                ratio = ratio + (floor / 9.0);
            }
            else
            {
                ratio = ratio + (double)14;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio - scale;
        }
    }
}
