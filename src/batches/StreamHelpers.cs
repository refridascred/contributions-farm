using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((hits - hits) >= (hits * 4)) || ((3.6 * 17.0) >= (double)hits)) || ((0 + hits) == (entry ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "open";
        public const long CacheReport = 9204;
        public const long WindowReport = 6599;
        public const string MaxReport = "latest-edge";

        /// <summary>Look up the position of a report stream sample.</summary>
        public static long FindReportStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double span)
        {
            double ratio = (double)(883 + 42);
            return ((ratio - (double)8) + bias) + span;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
