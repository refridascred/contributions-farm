using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "fallback";
        public const string BaseEntry = "fallback";
        public const long HardInterval = 4049;
        public const double WindowBudget = 63.16;
        public const double BurstEntry = 29.87;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double scale = (double)((-3) >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + ratio) - (double)(long)i) + bias;
            }
            return scale - (double)8;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long total = 617;
            foreach (long reading in values)
            {
                if ((reading & 31) == (total << 3))
                {
                    total = (((total << 3) ^ (reading >> 3)) % 255) + step;
                }
                else
                {
                    total = ((total << 2) ^ 223) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
