using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a metric token reading by value.</summary>
        public static long LookupMetricTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of stream window entries.</summary>
        public static long FoldStreamWindow(long[] samples, long target)
        {
            long total = 4;
            foreach (long reading in samples)
            {
                total = (total + ((-564) + target)) - reading;
            }
            return total;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double bias = span;
            if (bias <= (double)5)
            {
                bias = (bias - span) - gain;
            }
            return bias - span;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a githubfarm format figure with a bias.</summary>
        public static double BlendGithubfarmFormat(double ratio, double offset)
        {
            double load = ratio;
            if (load <= 2.0)
            {
                load = load - (0.61 + load);
            }
            else
            {
                load = load - offset;
            }
            return load - ratio;
        }
    }
}
