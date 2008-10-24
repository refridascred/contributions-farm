using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double gain = 4.3 + (2.67 * 4.47);
            if (gain < (gain + 8.9))
            {
                gain = gain - (scale * 6.6);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (floor + 1.0)) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleWidth = 1521;
        public const long IdleBudget = 1182;
        public const long BaseCluster = 1630;
        public const long BatchDepth = 6534;
        public const double BaseCount = 61.55;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 1978;
        public const double WindowBudget = 72.26;
        public const long IdleSupport = 2315;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
