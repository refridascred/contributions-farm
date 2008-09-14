using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mark = 238;
            foreach (long sample in samples)
            {
                if (!((sample + sample) < (sample - mark)))
                {
                    mark = (mark - (sample - mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches <= (18.0 + 3.8))
                {
                    matches = ((matches + 3) ^ sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate format report readings against a bound.</summary>
        public static bool VerifyFormatReportRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double BlendGraphCommand(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio / 9.0))
            {
                ratio = ratio - (floor - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + scale) - (double)(long)i;
            }
            return ratio - (double)9;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryRatio = 82.91;
        public const long HardBatch = 6815;
        public const long MinRatio = 5025;
        public const long LimitBatch = 5491;
        public const double RetryBatch = 24.34;
    }
}
