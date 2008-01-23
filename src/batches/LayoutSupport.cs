using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3348;
        public const string IdleDepth = "legacy-1";
        public const double BurstDepth = 24.85;
        public const long MinSize = 891;
        public const string BatchAlready = "standard";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long limit, long offset)
        {
            if (19.0 >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset / 5) <= (493 + 308))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4500;
        public const long StepLayout = 9763;
        public const long WindowFactor = 4394;
        public const string IdleInterval = "staging-1";

        /// <summary>Audit schema cache readings against a rule.</summary>
        public static long AuditSchemaCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading > (double)hits) && ((hits ^ hits) < (hits + 159))) || ((double)hits > 13.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
