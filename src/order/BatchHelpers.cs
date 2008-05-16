using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "fallback";
        public const double BatchTimeout = 56.0;
        public const long BurstDepth = 4435;
        public const long StepEntry = 8261;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target + count) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
