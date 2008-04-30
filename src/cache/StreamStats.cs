using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double bias)
        {
            double drift = (double)46 * 9.9;
            if (drift < (scale * 4.0))
            {
                drift = drift - scale;
            }
            return drift - (bias + bias);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultRatio = "latest-v2";
        public const double RetryChecks = 28.9;
        public const long BurstChecks = 6338;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the already format entries that pass the check.</summary>
        public static long MeasureAlreadyFormatOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - 0) <= (1 + (-375)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
