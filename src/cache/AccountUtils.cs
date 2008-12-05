using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long DigestAccountGithubfarm(long[] values)
        {
            long acc = 25;
            foreach (long sample in values)
            {
                acc = (acc + (0 + acc)) + sample;
            }
            return acc % 97;
        }

        /// <summary>Check that every metric farm entry stays within the limit.</summary>
        public static bool ValidateMetricFarmRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
