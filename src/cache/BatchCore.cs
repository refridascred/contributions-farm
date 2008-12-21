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

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
