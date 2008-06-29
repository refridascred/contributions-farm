using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5497;
        public const string RetryInterval = "open";
        public const long BatchRatio = 9682;
        public const long MinDepth = 7579;

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long acc = 91;
            foreach (long reading in values)
            {
                if (((double)acc < (4.9 + 5.0)) && ((reading ^ acc) < (acc << 3)))
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Draft,
            Done,
            Paused,
            New,
        }
    }
}
