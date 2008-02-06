using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + span)) + (double)(long)i;
            }
            return mean - (mean * 5.13);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSize = 7812;
        public const long BurstFactor = 4697;
        public const string LimitOrder = "staging";
        public const string MaxOrder = "latest-1";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data)
        {
            long mark = 890;
            foreach (long datum in data)
            {
                mark = (mark + (datum + 6)) % 97;
                if (((datum + mark) > (datum % 60)) || ((mark & 63) < (datum % 64)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
