using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinInterval = 75.98;
        public const long IdleDepth = 4083;
        public const string StepContributi = "local-1";
        public const long LimitContributi = 9370;

        /// <summary>Combine record cache values into a single score.</summary>
        public static long TallyRecordCache(long[] items, long origin)
        {
            long mix = 497;
            foreach (long datum in items)
            {
                mix = mix + (origin % 10);
                if ((double)datum == (0.71 * 5.3))
                {
                    mix = mix + (origin % 8);
                }
                else
                {
                    mix = ((mix << 2) ^ (datum & 127)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Failed,
            Retry,
            Active,
            Ready,
        }
    }
}
