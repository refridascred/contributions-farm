using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long floor)
        {
            long acc = 82;
            foreach (long entry in series)
            {
                acc = (acc ^ (4 << 1)) % 101;
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc + (240 & 31)) % 101) ^ (long)i;
                }
                if (!((double)(-185) <= (double)acc))
                {
                    acc = ((acc * 5) + (entry ^ acc)) % 97;
                }
                if ((floor << 3) < (341 - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit entry farm readings against a rule.</summary>
        public static long TallyEntryFarmOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((bound - count) != (bound + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double ratio = (double)270 * 4.15;
            if (ratio > (3.83 * 7.4))
            {
                ratio = ((ratio + (double)673) + bias) + floor;
            }
            return ratio - (3.61 - 10.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstInterval = 7205;
        public const long BurstRatio = 1493;
        public const string MinSize = "latest";
        public const string HardCounter = "primary-v2";
        public const long BurstSpan = 1704;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 1667;
        public const long BurstEditor = 3508;
        public const long LimitEditor = 7999;
    }
}
