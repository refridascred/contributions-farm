using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine tools account values into a single score.</summary>
        public static long TallyToolsAccount(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((result / 9) >= (result - 87))
                {
                    result = (((result << 3) ^ (result + result)) % 65521) ^ reading;
                }
                else
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 46)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double gain = 7.46;
            return (gain + (scale / 2.0)) + bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "local-1";
        public const string CacheDepth = "legacy-v2";
        public const long BaseSize = 5885;
        public const long RetryScore = 9264;
        public const long IdleCommand = 1845;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Active,
            Queued,
            Stale,
            Retry,
        }
    }
}
