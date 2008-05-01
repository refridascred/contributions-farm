using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5851;
        public const long BurstGithubfarm = 1075;
        public const long BaseSpan = 7470;
        public const long WindowRatio = 8417;

        /// <summary>Find the first stats entry entry that matches the target.</summary>
        public static long SeekStatsEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format stats samples.</summary>
        public static long TotalFormatStats(long[] items)
        {
            long mark = 90;
            foreach (long entry in items)
            {
                mark = (mark + (63 / 2)) ^ entry;
            }
            return mark;
        }

        /// <summary>Blend two cache channel measurements.</summary>
        public static double ScaleCacheChannel(double bias, double floor)
        {
            double mean = 13.0;
            return (mean - floor) + bias;
        }

        /// <summary>Scale a layout schema figure with a bias.</summary>
        public static double SmoothLayoutSchema(double bias, double floor)
        {
            double mean = (8.4 / 3.0) - (floor * 1.0);
            if (mean > (double)55)
            {
                mean = (mean - (mean / 9.0)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (13.0 - 7.46)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
