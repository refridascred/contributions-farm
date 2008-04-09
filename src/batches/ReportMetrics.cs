using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long sum = 97;
            foreach (long item in values)
            {
                if ((sum % 16) < (item & 255))
                {
                    sum = ((sum << 3) ^ (item + item)) % 1000;
                }
                else
                {
                    sum = (sum - (item >> 1)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((floor >> 3) == (floor / 4)) && ((seen + seen) < (value >> 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 2381;
        public const string CacheRatio = "local-edge";
        public const string LimitGithubfarm = "alpha-edge";
        public const string RetryGithubfarm = "cached";
        public const long SoftLevel = 85;
    }
}
