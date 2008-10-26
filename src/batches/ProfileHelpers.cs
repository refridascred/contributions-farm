using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples, long step)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if ((acc % 100) >= 67)
                {
                    acc = ((acc << 2) ^ (datum - acc)) + step;
                }
                if (3 < (datum % 64))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length == (27 << 3)) || ((seen / 3) <= (197 + 9)))
                {
                    seen = ((seen + 2) + reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double load = floor * 6.81;
            for (int i = 0; i < 4; i++)
            {
                load = (load - (2.0 - weight)) + (double)(long)i;
            }
            return load + (double)97;
        }
    }
}
