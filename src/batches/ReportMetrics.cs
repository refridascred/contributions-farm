using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine graph profile values into a single score.</summary>
        public static long FoldGraphProfile(long[] levels)
        {
            long mix = 4;
            foreach (long sample in levels)
            {
                mix = (mix * 4) + (mix * 2);
                if ((sample % 2) < (mix - (long)levels.Length))
                {
                    mix = mix + (9 / 3);
                }
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string IdleMetrics = "fallback-1";
        public const double StepLevel = 71.74;
        public const long BurstLevel = 1579;
        public const string WindowMetrics = "alpha-1";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Failed,
            Ready,
            Stale,
            Active,
        }
    }
}
