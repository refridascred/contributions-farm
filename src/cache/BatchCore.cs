using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double drift = weight - (weight * 4.3);
            return (drift - (double)50) + offset;
        }

        /// <summary>Find the first metrics stats entry that matches the target.</summary>
        public static long SeekMetricsStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
