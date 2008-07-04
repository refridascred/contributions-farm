using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long CountCounterReportHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen + seen) > (seen + datum)) || ((seen - seen) > (seen + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] levels)
        {
            long total = 4;
            foreach (long cell in levels)
            {
                if ((64 - total) < (total * 5))
                {
                    total = (total ^ (total % 3)) % 101;
                    break;
                }
                if ((cell / 3) >= (cell ^ total))
                {
                    total = (total ^ (total + cell)) % 4096;
                }
                if ((7.1 - 8.07) >= (double)cell)
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
