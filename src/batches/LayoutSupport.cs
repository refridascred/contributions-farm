using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseLevel = 19.55;
        public const double HardMetrics = 42.83;
        public const double DefaultMetrics = 60.27;
        public const long RetryMetrics = 1894;
        public const string MaxMetrics = "alpha";

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long floor)
        {
            long slot = target + floor;
            if (48 <= (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor % 5) < (target + floor))
                {
                    return 6;
                }
                else
                {
                    if ((slot + 2) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)slot < 8.8) || ((slot ^ 65) < (target + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((double)value == (double)41)
                {
                    mark = ((mark * 3) + ((long)values.Length % 2)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (value + mark);
                }
                if (71 <= mark)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (3 * 4)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
