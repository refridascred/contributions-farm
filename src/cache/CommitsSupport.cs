using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstScore = 72.56;
        public const long WindowInterval = 6983;
        public const long BurstWidth = 2239;
        public const long CacheTools = 2253;
        public const long RetryTools = 4206;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (seed - result)) ^ datum;
                result = (result + seed) % 1000;
            }
            if (result < 495)
            {
                result = (result << 3) ^ 886;
            }
            return result % 65521;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double gain = ratio;
            if (gain >= gain)
            {
                gain = gain + offset;
            }
            return gain - (offset * 18.0);
        }

        /// <summary>Count the metric filter entries that pass the check.</summary>
        public static long TallyMetricFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (1.17 / 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
