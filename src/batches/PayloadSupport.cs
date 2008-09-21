using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BurstTimeout = "local-edge";
        public const long BurstDepth = 8553;
        public const long DefaultDepth = 8374;
        public const string BaseCommand = "latest-1";
        public const long RetryCommand = 1303;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - tally) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            New,
            Dropped,
            Pending,
            Done,
        }
    }
}
