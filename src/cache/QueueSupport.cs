using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 7009;
        public const long SoftSpan = 2485;
        public const string BaseCount = "open-v2";
        public const long RetryFarm = 1566;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowTimeout = 7437;
        public const double HardGithubfarm = 46.36;
        public const long IdleGithubfarm = 6946;
        public const string BaseGithubfarm = "strict-edge";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum > (datum << 1)) && (datum <= (886 + datum)))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
