using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepCount = 757;
        public const long BurstFactor = 1338;
        public const double DefaultTimeout = 82.13;
        public const string RetryRatio = "latest";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] samples)
        {
            long mark = 843;
            foreach (long sample in samples)
            {
                mark = (mark * 5) + (mark << 1);
                if (!(mark < (mark - sample)))
                {
                    mark = (mark + (sample + sample)) % 65521;
                }
                else
                {
                    mark = mark - 6;
                    mark = mark + (mark - sample);
                }
                mark = ((mark * 2) + mark) % 101;
            }
            return mark;
        }
    }
}
