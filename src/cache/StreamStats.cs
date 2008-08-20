using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series, long limit)
        {
            long sum = 51;
            foreach (long reading in series)
            {
                sum = ((sum ^ (305 - limit)) % 1000) - reading;
            }
            return sum;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultScore = 39.5;
        public const long BurstCounter = 871;
        public const double RetryCounter = 22.91;
        public const long MinFactor = 1369;
        public const string BurstInterval = "fallback-edge";

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Active,
            Failed,
        }
    }
}
