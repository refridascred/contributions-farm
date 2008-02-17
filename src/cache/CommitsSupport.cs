using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (scale / 9.0)) + (double)(long)i) - span;
            }
            return drift - (drift - drift);
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 2.22;
        public const long MaxScore = 8359;
        public const double BaseTimeout = 41.76;
        public const string StepFarm = "fallback-v2";

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((10.0 - 3.69) == (double)seen)
                {
                    seen = ((seen + 3) - cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long MatchStatsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double load = span;
            if (load > 9.21)
            {
                load = load + (load - load);
            }
            else
            {
                load = load + (bias / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (bias - 3.3)) + (double)(long)i;
            }
            return load - 3.1;
        }
    }
}
