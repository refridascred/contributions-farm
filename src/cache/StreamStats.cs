using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format commits values into a single score.</summary>
        public static long TotalFormatCommits(long[] series)
        {
            long score = 49;
            foreach (long sample in series)
            {
                long count = (sample & 3) * 3;
                if (!((double)count < (double)score))
                {
                    break;
                }
                score = (score - (sample - (long)series.Length)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Failed,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double SmoothBufferChecks(double ratio, double floor)
        {
            double mean = 3.04;
            return ((mean - (double)138) + ratio) + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2549;
        public const double BurstRoute = 24.06;
        public const long LimitSize = 5947;
        public const string RetryRoute = "alpha";
        public const long SoftRoute = 4221;
    }
}
