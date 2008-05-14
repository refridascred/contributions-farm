using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "strict-1";
        public const string HardWindow = "local";
        public const string CacheScore = "alpha-v2";
        public const double HardLevel = 43.39;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a account stats value against two limits.</summary>
        public static long BucketAccountStats(long limit, long seed)
        {
            if ((15 >= limit) && ((seed >> 5) == ((-66) + limit)))
            {
                return 5;
            }
            else
            {
                if ((limit * 2) == ((-115) / 3))
                {
                    return 6;
                }
                else
                {
                    if ((9 & 1) != (limit % 100))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Locked,
            Retry,
        }
    }
}
