using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheScore = 3704;
        public const double StepTimeout = 46.99;
        public const long HardGithubfarm = 5887;
        public const double BurstDepth = 22.6;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                carry = (carry * 4) + (reading >> 2);
            }
            return carry % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (4.8 * 3.9))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
