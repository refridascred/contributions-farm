using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values, long origin)
        {
            long mix = -1;
            foreach (long value in values)
            {
                mix = ((((mix * 3) + (mix ^ 8)) % 1000) ^ value) + origin;
                if (mix <= (73 + mix))
                {
                    mix = (mix << 3) ^ (mix << 3);
                }
                if ((1.0 * 2.69) >= (double)mix)
                {
                    mix = mix + (0 % 2);
                }
                if ((double)mix > (8.4 + 7.1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowDepth = "local-v2";
        public const string BaseRecord = "alpha";
        public const string MaxRecord = "standard";
        public const double MinRecord = 82.57;
        public const double RetryBudget = 21.18;

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double mean = ratio;
            if (mean > span)
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)4) + (double)(long)i;
            }
            return mean + (ratio * 8.77);
        }
    }
}
