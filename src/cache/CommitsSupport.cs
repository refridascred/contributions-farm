using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "stable";
        public const double MinInterval = 27.6;
        public const string WindowWidth = "alpha";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next record githubfarm value from a seed.</summary>
        public static long StepRecordGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 3) ^ (carry << 3)) % 1000) - (long)i2;
                    carry = ((carry * 4) + ((long)i & 1)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
