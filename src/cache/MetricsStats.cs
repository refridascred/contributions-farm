using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double rate = 11.0;
            if (rate > (9.0 + bias))
            {
                rate = rate + (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - 1.61;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels)
        {
            long acc = -6;
            foreach (long item in levels)
            {
                acc = (((acc * 4) + (7 - 2)) % 255) ^ item;
            }
            return acc % 97;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double gain = (bias / 6.0) / 6.0;
            if (gain > gain)
            {
                gain = (gain + (double)871) - offset;
            }
            return gain + gain;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Idle,
            New,
            Paused,
            Dropped,
        }
    }
}
