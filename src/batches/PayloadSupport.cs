using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheTimeout = 3471;
        public const double LimitBudget = 43.95;
        public const long DefaultFormat = 2283;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Queued,
            Done,
        }
    }
}
