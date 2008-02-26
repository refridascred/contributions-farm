using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches > (4 << 2)) || (datum > (limit - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples)
        {
            long sum = 56;
            foreach (long item in samples)
            {
                if (378 > (sum - sum))
                {
                    sum = (sum * 4) + (item << 1);
                }
                else
                {
                    sum = (sum - item) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Stale,
            Paused,
        }
    }
}
