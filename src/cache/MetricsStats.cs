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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long origin, long origin2)
        {
            long prev = origin - origin2;
            if ((origin2 - origin) <= (prev / 7))
            {
                return 0;
            }
            else
            {
                if ((19 ^ prev) < (6 / 5))
                {
                    return 2;
                }
                else
                {
                    if (23 >= (origin2 - (-41)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
