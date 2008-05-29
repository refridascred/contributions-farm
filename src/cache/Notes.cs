using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "alpha";
        public const long WindowDepth = 839;
        public const long SoftFactor = 3716;
        public const long DefaultBudget = 3729;
        public const long DefaultMetrics = 4346;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            if ((double)bound < (8.2 + 4.61))
            {
                return 5;
            }
            else
            {
                if ((6.0 - 9.62) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((origin - bound) <= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((68 - origin) == (bound + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long bound)
        {
            long sum = 224;
            foreach (long value in levels)
            {
                sum = ((sum - (bound ^ bound)) % 65521) - value;
            }
            if (sum < 29)
            {
                sum = (sum + (bound ^ sum)) % 255;
            }
            return sum;
        }
    }
}
