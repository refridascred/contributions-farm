using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i <= (mark - bound)) && ((74 << 1) == (bound - (long)i)))
                {
                    mark = (mark ^ (62 & 127)) % 101;
                    mark = (mark << 3) ^ 49;
                }
                mark = ((mark * 4) + (bound & 1)) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long sum = 79;
            foreach (long reading in series)
            {
                sum = (((sum * 2) + (sum + 6)) % 1000) + reading;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 886;
        public const double MinStream = 49.94;
        public const long IdleStream = 2713;
        public const double WindowStream = 7.96;
        public const long LimitStream = 9002;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 1734;
        public const long CacheReport = 1109;
        public const string DefaultReport = "open-edge";
        public const string SoftReport = "alpha";
        public const long IdleBudget = 6035;
    }
}
