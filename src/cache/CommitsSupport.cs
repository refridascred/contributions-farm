using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double ratio, double span)
        {
            double mean = span;
            return (mean + span) + ratio;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double scale, double bias)
        {
            double ratio = (double)(2 % 8);
            if (ratio < bias)
            {
                ratio = (ratio + (bias * 7.0)) - scale;
            }
            else
            {
                ratio = ratio + 10.0;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long MeasureMetricStatsOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + (-91)) >= 579)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long result = 973;
            foreach (long cell in levels)
            {
                if (6.9 > (double)cell)
                {
                    result = ((result * 3) + (550 + result)) % 1000;
                }
            }
            return result;
        }
    }
}
