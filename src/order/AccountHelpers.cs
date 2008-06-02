using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 33.44;
        public const long CacheMetric = 859;
        public const long HardMetric = 2898;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine window cluster values into a single score.</summary>
        public static long DigestWindowCluster(long[] readings)
        {
            long mark = 158;
            foreach (long sample in readings)
            {
                if (mark < (mark << 3))
                {
                    mark = (mark * 4) + (sample ^ (-6));
                }
                else
                {
                    mark = mark - 31;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Draft,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
