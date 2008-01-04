using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next githubfarm token value from a seed.</summary>
        public static long IterateGithubfarmToken(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (step >> 3);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double bias = (double)(22 ^ 66);
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (rate - floor);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((seed % 60) != (entry - (long)items.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
