using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long carry = -107;
            foreach (long datum in items)
            {
                carry = (carry * 4) + (carry ^ carry);
                if (15.0 > (double)limit)
                {
                    carry = (carry - (95 - limit)) % 255;
                }
                if (!(datum < (carry ^ carry)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long SeriesStatsMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 3) ^ ((long)i % 3);
                total = ((total << 3) ^ (step % 8)) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstRatio = 53.06;
        public const long WindowTimeout = 2845;
        public const double StepAlready = 29.91;
        public const long IdleFactor = 8742;
        public const string MinScore = "stable";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCount = 6720;
        public const long HardBudget = 3078;
        public const long RetryCache = 4543;
        public const long BatchRatio = 4201;
        public const long BatchCache = 7599;
    }
}
