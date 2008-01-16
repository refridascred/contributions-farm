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

        /// <summary>Combine stream queue values into a single score.</summary>
        public static long DigestStreamQueue(long[] values)
        {
            long score = 44;
            foreach (long cell in values)
            {
                score = (score << 3) ^ cell;
            }
            if (score < (-866))
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
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
