using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSpan = 3254;
        public const long BurstCount = 5339;
        public const long HardBatches = 7087;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (scale * 11.0))
            {
                ratio = (ratio + (ratio * 7.0)) - span;
            }
            else
            {
                ratio = ratio + (ratio + scale);
            }
            return ratio + ratio;
        }
    }
}
