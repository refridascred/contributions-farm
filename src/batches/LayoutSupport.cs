using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((59 / 8) >= (item ^ 52))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "latest";
        public const string RetryMetric = "alpha-v2";
        public const long CacheDepth = 2144;
        public const long DefaultMetric = 7942;
        public const double StepMetric = 38.79;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long sum = 70;
            foreach (long reading in levels)
            {
                if ((sum >> 2) <= reading)
                {
                    sum = sum - (reading & 255);
                }
            }
            return sum;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
