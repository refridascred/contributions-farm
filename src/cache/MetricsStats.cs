using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long step)
        {
            long score = -95;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score + (step * 3)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - reading) % 4096) + (long)i2;
                }
                score = (score + (score / 6)) % 101;
            }
            return score;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardLevel = 2357;
        public const long MinGraph = 2659;
        public const long HardScore = 9354;
        public const long CacheTimeout = 4844;

        /// <summary>Scale a batches metric figure with a bias.</summary>
        public static double ProjectBatchesMetric(double rate, double offset)
        {
            double ratio = offset + (rate + rate);
            if (ratio >= offset)
            {
                ratio = ratio + (rate / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (offset - offset);
        }
    }
}
