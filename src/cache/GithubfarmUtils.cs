using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double gain, double bias)
        {
            double rate = gain;
            if (rate >= gain)
            {
                rate = (rate + 4.3) + bias;
            }
            else
            {
                rate = rate - gain;
            }
            return rate - (double)116;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxScore = 8036;
        public const long HardStats = 9710;
        public const string BaseFactor = "standard-1";
        public const long BatchSize = 7533;
        public const long DefaultStats = 8113;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema context entries.</summary>
        public static long CombineSchemaContext(long[] readings, long limit)
        {
            long sum = 1;
            foreach (long entry in readings)
            {
                sum = (sum + 163) + entry;
                sum = ((sum * 4) + 54) % 1000;
            }
            if (sum < (-31))
            {
                sum = (sum ^ (limit - sum)) % 101;
            }
            return sum;
        }
    }
}
