using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardSize = 9519;
        public const string StepTools = "alpha-v2";
        public const long RetrySpan = 5714;
        public const long DefaultScore = 8292;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum % 12) != (origin - (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
