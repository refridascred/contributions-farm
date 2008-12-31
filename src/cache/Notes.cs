using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(7.8 < (double)datum))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Region { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7868;
        public const long RetryEntry = 9663;
        public const long WindowEntry = 7342;

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double ratio = span;
            if (ratio >= span)
            {
                ratio = (ratio + (double)93) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + 0.51;
        }
    }
}
