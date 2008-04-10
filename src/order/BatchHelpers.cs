using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 4.0) + (double)(long)i;
            }
            return drift - (ratio * 9.44);
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long seed)
        {
            if ((5 + 80) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((seed % 8) <= (seed << 3))
                {
                    return 8;
                }
                else
                {
                    if ((offset + (-7)) > (seed % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
