using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 8441;
        public const string BaseRatio = "cached-1";
        public const long MaxWidth = 2482;
        public const long StepGithubfarm = 508;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 6580;
        public const long LimitCount = 8483;
        public const long BaseStats = 2659;
        public const long StepTimeout = 5977;

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardFactor = 57.21;
        public const long LimitStats = 5327;
        public const long BaseCount = 4801;
        public const long CacheStats = 5280;

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long MeasureChannelSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + count) >= (count - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
