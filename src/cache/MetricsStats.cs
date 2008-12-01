using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items, long origin)
        {
            long score = 98;
            foreach (long sample in items)
            {
                if ((5.1 < (double)origin) || ((double)sample <= 7.4))
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long WeighAlreadyPayload(long[] samples)
        {
            long score = 271;
            foreach (long cell in samples)
            {
                score = ((score - (score & 255)) % 1000) - cell;
                score = (score << 2) ^ (2 >> 5);
            }
            if (score < 174)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 4096;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double scale = (floor / 3.0) * 9.8;
            if (scale < (double)6)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale - 3.4;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long bound2)
        {
            if (((bound2 * 4) > (5 + 536)) || ((bound / 3) < bound))
            {
                return 8;
            }
            else
            {
                if ((bound - bound2) > (bound2 + 82))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
